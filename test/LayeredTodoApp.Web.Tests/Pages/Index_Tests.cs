using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LayeredTodoApp.Pages;

public class Index_Tests : LayeredTodoAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
