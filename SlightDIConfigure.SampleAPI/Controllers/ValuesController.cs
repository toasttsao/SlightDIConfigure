using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SlightDIConfigure.SampleAPI.Imp;

namespace SlightDIConfigure.SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly  Iwithdraw  _withdraw;
        private readonly Ipay  _pay;
        private readonly Irefund _refund;
        public ValuesController( Iwithdraw  withdraw,Ipay  pay,Irefund refund){

            _withdraw =withdraw;
            _pay =pay;
            _refund =refund;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { _withdraw.WithdrawAction(), _pay.PayAction(),_refund.RefundAction() };
        }

       
    }
}
