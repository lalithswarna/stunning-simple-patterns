using System;

namespace Pattern1Singleton{
    public class DeviceDriver{

        private DeviceDriver(){ }
        private static DeviceDriver obj{ get; set;}

        public static DeviceDriver Instance{
            get{
                if(obj == null){
                    obj = new DeviceDriver();
                }
                return obj;
            }
        }

    }
}