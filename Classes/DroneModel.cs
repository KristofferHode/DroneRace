namespace DroneRace;
    public class DroneModel
    {
        public string Name{get;set;}
        public int MaxCheckpoints{get;set;}
        public int DelayMS{get;set;}


    public DroneModel(string name,int maxCheckpoints,int delayMS)
        {
            Name=name;
            MaxCheckpoints=maxCheckpoints;
            DelayMS=delayMS;
        }
    public void DisplayInfo()
        {
            
        }
    }
        
    
    
    