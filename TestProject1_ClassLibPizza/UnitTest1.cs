using WebAppDETAug2022.Models;
using WebAppDETAug2022.Services;

namespace TestProject1_ClassLibPizza
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaServices.GetAll().Count;
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test_AddPizza()
        {
            Pizza p = new Pizza { Name = "Veg", Size = PizzaSize.Medium, IsGlutenFree = true };

            PizzaServices.Add(p);

            Pizza verify = PizzaServices.Get(3);
            Assert.Equal(3, PizzaServices.GetAll().Count());
            Assert.NotNull(verify.Id);
        }
    }
}