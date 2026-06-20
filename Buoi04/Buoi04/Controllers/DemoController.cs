using Buoi04.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buoi04.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult DemoSync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var resultA = Demo.A();
            var resultB = Demo.B();
            Demo.C();
            stopwatch.Stop();
            
            return Content($"Result A: {resultA}, Result B: {resultB}, Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        public async Task<IActionResult> AsyncDemo()
        {
            var sw = new Stopwatch();
            sw.Start();
            var a = Demo.AA();
            var b = Demo.BB();
            var c = Demo.CC();
            await a; await b; await c;
            //Task.WaitAll();
            sw.Stop();

            return Content($"Chạy hết {sw.ElapsedMilliseconds}ms");
        }

    }
}
