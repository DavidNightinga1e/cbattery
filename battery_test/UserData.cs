using System;

namespace cbattery
{
    [Serializable]
    public class UserData
    {
        public string Name { set; get; }
        public IconManager IconManager;
        public TrayTextChecks TrayTextChecks;

        public UserData()
        {
            IconManager = new IconManager();
            TrayTextChecks = new TrayTextChecks();
        }
    }
    
    [Serializable]
    public class TrayTextChecks
    {
        public bool P;
        public bool C;
        public bool V;
        public bool W;
        public bool D;
        public bool T;
        public bool S;
        
        public TrayTextChecks()
        {
            P = C = V = W = D = T = S = true;
        }
    }
}