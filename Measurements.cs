using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace RedAlign.Data
{
    public class Measurements
    {
        public ObjectId _id { get; private set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public EquipmentMeasured equipment { get; set; }
        public AlignmentHardware hardware { get; set;}
        public Routine routine { get; set; }
        public List<Measurement> measurements { get; set; }

        public Measurements()
        {
            routine = new Routine();
            measurements = new List<Measurement>();
            equipment = new EquipmentMeasured();
            hardware = new AlignmentHardware();
        }

        public void AssignObjectId()
        {
            _id = ObjectId.GenerateNewId();
        }
    }

    public class EquipmentMeasured
    {
        public int id { get; set; }
        // add properties releated to equipment measured, like pump/motor/facility (not originally included since it seems redundent)
    }

    public class AlignmentHardware
    {
        public string id { get; set; }
        public string version { get; set; }
        public string softwareVersion { get; set; }
    }

    public class Routine
    {
        public string name { get; set; }
        public string script { get; set; }
    }

    public class Measurement
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double distance { get; set; }

        public Measurement()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
            distance = 0.0;
        }
    }
}
