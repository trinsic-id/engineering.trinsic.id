using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using Trinsic.Blog.ShortCodes;

namespace Trinsic.Blog
{
  public class Program
  {
    public static async Task<int> Main(string[] args) =>
      await Bootstrapper
        .Factory
        .CreateWeb(args)
        .AddShortcode<GitShortCode>()
        .RunAsync();
  }
}
