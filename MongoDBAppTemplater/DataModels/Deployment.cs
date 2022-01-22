namespace MongoDBAppTemplater.DataModels {
    class Deployment {
        public string Name {get;set;}
        public string DataClassification {get;set;} = "Moderate Risk";
        public string UsageType {get;set;} = "Development";
        public string IdenticalLowers {get;set;} = "No";
        public int HA {get;set;} = 3;
        public int Analytics {get;set;} = 0;
        public int DataGB {get;set;} = 0;
        public string DataLocality {get;set;} = "No";
        public List<string> Localities {get;set;} = null;
        public string Backup {get;set;} = "None";
        public List<string> ShardKeys {get;set;} = null;
    }
}