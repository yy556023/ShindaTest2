using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ShindaTest2.Models.Shinda;

namespace ShindaTest2.Controllers
{
    public class ShindaController : Controller
    {
        private readonly dbTestL1Context _context;

        public ShindaController(dbTestL1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.TblProduct.ToList();

            ViewBag.list = list;

            //var product = _context.TblOrder.ToList();

            //ViewBag.p = product;

            var a = _context.TblOrderDetails.ToList();

            ViewBag.a = a;

            return View();
        }

        public async Task<ActionResult> Get()
        {
            var showls = from o in _context.TblOrder
                         select new Sign()
                         {
                             cID = o.COrderId,
                             cName = o.CName,
                             showDt = o.CDt.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                             showTot = o.CSubTotal.Value.ToString("C"),
                             items = o.COrderId
                         };

            var jsres = JsonConvert.SerializeObject(showls);

            return Ok(jsres);
        }

        public async Task<ActionResult> GetID()
        {


            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Sign model)
        {
            var Str = string.Empty;

            if (model.cName == null || model.cName == "")
            {
                Str += "請輸入姓名\n";
            }

            var temp = model.items.Split(',');

            var count = 0;

            foreach (var item in temp)
            {
                if (item != "0")
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Str += "請至少輸入一項\n";
            }

            if (!string.IsNullOrEmpty(Str))
            {
                var res = new
                {
                    Msg = Str
                };

                var jsres = JsonConvert.SerializeObject(res);

                return Ok(jsres);
            }
            else
            {
                decimal total = 0;

                var pricels = _context.TblProduct.ToList();

                var date = DateTime.Now.ToString("yyMMddHHmmss");

                for (int i = 0; i < pricels.Count; i++)
                {
                    total += (pricels[i].CPrice.Value * int.Parse(temp[i]));
                }

                var newOrder = new TblOrder()
                {
                    COrderId = model.cName + date,
                    CName = model.cName,
                    CDt = DateTime.Now,
                    CSubTotal = total,
                };

                _context.TblOrder.Add(newOrder);

                _context.SaveChanges();


                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] != "0")
                    {
                        var newOrderD = new TblOrderDetails()
                        {
                            COrderId = model.cName + date,
                            CProductId = pricels[i].CProdcutId.Value,
                            CCount = int.Parse(temp[i]),
                            CTotal = (pricels[i].CPrice * int.Parse(temp[i]))
                        };

                         _context.TblOrderDetails.Add(newOrderD);
                    }

                    _context.SaveChanges();
                }

                var showls = from o in _context.TblOrder
                             select new Sign()
                             {
                                 cID = o.COrderId,
                                 cName = o.CName,
                                 showDt = o.CDt.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                                 showTot = o.CSubTotal.Value.ToString("C"),
                                 items = o.COrderId
                             };

                var jsres = JsonConvert.SerializeObject(showls);

                return Ok(jsres);
            }

        }
    }
}
