namespace Pattern2Factory{
    public class CalculateFactory 
    {
        public ICalculate getCalculationFactory(string type){
        ICalculate obj = null;
            if(type.ToLower().Equals("add")){
                obj = new Add();
            }
            else if(type.ToLower().Equals("multiply")){
                obj = new Multiply();
            }
            else if(type.ToLower().Equals("divide")){
                obj = new Divide();
            }
            return obj;
        }
    }
}