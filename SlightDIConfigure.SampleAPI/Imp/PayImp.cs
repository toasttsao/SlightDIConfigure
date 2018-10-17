namespace SlightDIConfigure.SampleAPI.Imp
{
    public class PayImp : Ipay
    {
        public string PayAction()
        {
            return "pay";
        }
    }
}