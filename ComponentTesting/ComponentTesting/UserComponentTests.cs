namespace ComponentTesting
{
    using BazorTests.Client.Pages;
    using BazorTests.Shared.DTOs;
    using FluentAssertions;
    using Microsoft.AspNetCore.Components.Testing;
    using System;
    using Xunit;

    public class UserComponentTests
    {
        public class UsersComponentTests
        {
            private TestHost host = new TestHost();

            [Fact]
            public void UserComponent_CheckInitialState()
            {
                var requestMoq = host.AddMockHttp().Capture("/api/users/");
                var component = host.AddComponent<Users>();

                // Initial component loading state
                component.Find("#userCount").InnerText.Should().Be("0");
                component.GetMarkup().Should().Contain("Loading...");
            }

            //ToDO: check why WaitForNextRender task is not finished and throws exception.
            [Fact]
            public void UserComponent_HasSingleUser()
            {
                var requestMoq = host.AddMockHttp().Capture("/api/users/");
                var component = host.AddComponent<Users>();

                component.GetMarkup().Should().Contain("Loading...");

                // Simulate response from the HttpClient
                host.WaitForNextRender(() => requestMoq.SetResult(new[]
                {
                    new  UserDto { Email = "test" },
                }));

                // Now component should have all data.
                component.GetMarkup().Should().NotContain("Loading...");
                component.Find("#userCount").InnerText.Should().Be("1");
            }
        }
    }
}
