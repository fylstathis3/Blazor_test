using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static BlazorTest.Client.Shared.MainLayout;

namespace BlazorTest.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [CascadingParameter] public AppState AppState { get; set; }
        // [CascadingParameter(Name = "Size")] public string Size { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;
        IJSObjectReference module;

        [JSInvokable]
        public async Task IncrementCount()
        {
            // Javascript Isolation
            module = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await module.InvokeVoidAsync("displayAlert", "Hello world");

            currentCount++;
            singleton.Value += 1;
            transient.Value += 1;
            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        private async Task IncrementCountJavascript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}