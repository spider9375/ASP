using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayPalCheckoutSdk.Orders;
using PayPalHttp;

namespace BlazorApp1.Data.PayPalClient
{
    public class CreateOrder
    {
        //Below function can be used to build the create order request body with minimum payload.
        private static OrderRequest BuildRequestBodyWithMinimumFields(string amount)
        {
            OrderRequest orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "AUTHORIZE",
                ApplicationContext = new ApplicationContext
                {
                    CancelUrl = "https://www.example.com",
                    ReturnUrl = "https://localhost:5001/payment/success"
                },
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest{
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            CurrencyCode = "USD",
                            Value = amount
                        }

                    }
                }
            };

            return orderRequest;
        }

        //Below function can be used to create an order with minimum payload.
        public async static Task<HttpResponse> CreateOrderWithMinimumFields(string _amount)
        { 
            Console.WriteLine("Create Order with minimum payload..");
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(BuildRequestBodyWithMinimumFields(_amount));
            var client = PayPalClient.client();
            var response = await client.Execute(request);

            var result = response.Result<Order>();
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Order Id: {0}", result.Id);
            Console.WriteLine("Intent: {0}", result.CheckoutPaymentIntent);
            Console.WriteLine("Links:");
            foreach (LinkDescription link in result.Links)
            {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
            AmountWithBreakdown amount = result.PurchaseUnits[0].AmountWithBreakdown;
            Console.WriteLine("Total Amount: {0} {1}", amount.CurrencyCode, amount.Value);

            return response;
        }

        // static void Main(string[] args)
        // {
        //    CreateOrder(true).Wait();
        //    CreateOrderWithMinimumFields(true).Wait();
        // }
    }
}