using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieHost.CommandHandlers;
using MovieHost4;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var commandhandler = new MovieCommandHandler();
             Task<IEnumerable<Movie>> task = Task.Run<IEnumerable<Movie>>(async () => await commandhandler.GetTopratedMovies());
            Assert.IsTrue(task.Result.Any());
        }
    }
}
