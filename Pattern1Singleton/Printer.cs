using System;

namespace Pattern1Singleton{

// printer is a singleton class which always returns the same instance through GetInstanc()
// Call it eg: var printerObj = printer.GetInstance();
public class printer{
    // default constructor, it has same name as that of class it has no return type
    // First method that gets called whenever instance of class is created
    // public printer(){
    // }

    // // by making constructor private we are making this class has only one instance at any time
    private printer(){

    }

    private static printer printerObj;

    // this method ensures we always have only one instance returned
    // making this method static we can access it from outside
    public static printer GetInstance(){
        if(printerObj == null){
            // we can access constructor as this code is within same class
            printerObj = new printer();
        }
        return printerObj;
    }
}
}