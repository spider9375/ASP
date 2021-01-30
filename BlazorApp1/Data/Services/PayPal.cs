using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Orders;
using PayPalHttp;

namespace BlazorApp1.Data.Services
{
    public class PayPal
    {
        static String clientId = "AdonGGjFsn-lsmrvvEOy9bK2EytMLahaTN5N9SDW7CQhdikupYgzI6j2zOYb9FpBsGmVansGZR-sMpNB";
        static String secret = "EEFJWpNhpZ5R_n6Lrt3SfYaW87r_k-xBik7oTYRDbB3wReEGO4MYijrNzYwU7Gj-9cYT-wYHE5uqemmW";

        public static HttpClient client()
        {
            // Creating a sandbox environment
            PayPalEnvironment environment = new SandboxEnvironment(clientId, secret);

            // Creating a client for the environment
            PayPalHttpClient client = new PayPalHttpClient(environment);
            return client;
        }

        public async static Task<HttpResponse> createOrder()
        {
            HttpResponse response;
            // Construct a request object and set desired parameters
            // Here, OrdersCreateRequest() creates a POST request to /v2/checkout/orders
            var order = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        AmountWithBreakdown = new AmountWithBreakdown()
                        {
                            CurrencyCode = "BGN",
                            Value = "100.00"
                        }
                    }
                },
                ApplicationContext = new ApplicationContext()
                {
                    ReturnUrl = "https://www.example.com",
                    CancelUrl = "https://www.example.com"
                }
            };


            // Call API with your client and get a response for your call
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(order);
            response = await client().Execute(request);
            var statusCode = response.StatusCode;
            Order result = response.Result<Order>();
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Order Id: {0}", result.Id);
            Console.WriteLine("Intent: {0}", result.CheckoutPaymentIntent);
            Console.WriteLine("Links:");
            foreach (LinkDescription link in result.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
            return response;
        }
    }
}
