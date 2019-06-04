using System;
using System.Text;

namespace cbattery
{
    /// <summary>
    /// Possible data to display:
    ///
    /// Percent of charge
    /// Capacity: current / maximum
    /// Designed capacity
    /// Wear
    /// Voltage
    /// Discharge [wh, percent]
    /// Time to empty 
    /// </summary>
    public class BatteryStatus
    {
        private StringBuilder _stringBuilder;
        
        public int Percent { get; private set; }
        public float CurrentCapacity { get; private set; }
        public float MaximumCapacity { get; private set; }
        public float DesignedCapacity { get; private set; }
        public float Wear { get; private set; }
        public float Voltage { get; private set; }
        public float Discharge { get; private set; }
        public TimeSpan TimeEst { get; private set; }
        public DateTime TimeDsc { get; private set; }

        public BatteryStatus()
        {
            _stringBuilder = new StringBuilder();
        }

        public void Update()
        {
            var info = BatteryInfo.BatteryInfo.GetBatteryInformation();
            
            Voltage = (float)info.Voltage / 1000;
            DesignedCapacity = (float)info.DesignedMaxCapacity / 1000;
            CurrentCapacity = (float)info.CurrentCapacity / 1000;
            MaximumCapacity = (float)info.FullChargeCapacity / 1000;
            Discharge = (float)info.DischargeRate / 1000;

            Percent = Convert.ToInt32(Math.Round(100 * CurrentCapacity / MaximumCapacity));
            Wear = 100 * (1 - MaximumCapacity / DesignedCapacity);

            if (Discharge != 0)
            {
                var time = CurrentCapacity / -Discharge;
                TimeEst = new TimeSpan(
                    Convert.ToInt32(Math.Floor(time)),
                    Convert.ToInt32(time - Math.Floor(time)) * 60,
                    0);
                TimeDsc = DateTime.Now + TimeEst;
            }
            else
            {
                TimeEst = new TimeSpan();
                TimeDsc = new DateTime();
            }
        }

        public string GetVoltage(bool full)
        {
            return full ? $"[V] Voltage {Voltage:0.0} V" : $"V {Voltage:0.0}V";
        }

        public string GetCapacity(bool full)
        {
            return full ? $"[C] Capacity {CurrentCapacity:0.0}/{MaximumCapacity:0.0} Wh" : $"C {CurrentCapacity:0.0}/{MaximumCapacity:0.0}Wh";
        }

        public string GetPercent(bool full)
        {
            return full ? $"[P] Battery charge {Percent:0}%" : $"P {Percent:0}%";
        }

        public string GetWear(bool full)
        {
            return full ? $"[W] Wear {Wear:0.0}%" : $"W {Wear:0.0}%";
        }

        public string GetDischarge(bool full)
        {
            if (Discharge == 0) return full ? "[D] Charging": "D Charging";
            return full ? $"[D] Discharge rate {Discharge:0.0} Wh" : $"D {Discharge:0.0}Wh";
        }

        public string GetTimeEnd(bool full)
        {
            return full ? $"[S] Shutdown time {TimeDsc.ToShortTimeString()}" : $"S {TimeDsc.ToShortTimeString()}";
        }

        public string GetTimeEst(bool full)
        {
            return full ? $"[T] Time to discharge {TimeEst:hh\\:mm}" : $"T {TimeEst:hh\\:mm}";
        }

        public override string ToString()
        {
            _stringBuilder.Clear();

            _stringBuilder.Append(GetPercent(true) + "\n");
            _stringBuilder.Append(GetCapacity(true) + "\n");
            _stringBuilder.Append(GetVoltage(true) + "\n");
            _stringBuilder.Append(GetWear(true) + "\n");
            _stringBuilder.Append(GetDischarge(true) + "\n");
            _stringBuilder.Append(GetTimeEst(true) + "\n");
            _stringBuilder.Append(GetTimeEnd(true));
            
            return _stringBuilder.ToString();
        }
    }
}