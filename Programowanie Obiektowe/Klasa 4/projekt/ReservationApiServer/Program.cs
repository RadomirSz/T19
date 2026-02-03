using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ReservationApiServer
{
    internal class Program
    {
        private static readonly List<object> Reservations = new List<object>();
        private static HttpListener _listener;

        private static void Main(string[] args)
        {
            const string url = "http://localhost:8080/";
            _listener = new HttpListener();
            _listener.Prefixes.Add(url);

            try
            {
                _listener.Start();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║     SERWER API REZERWACJI URUCHOMIONY      ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine($"\nSłucham na: {url}");
                Console.WriteLine("Dostępne endpointy:");
                Console.WriteLine("  POST {0}api/reservations - Dodaj rezerwację", url);
                Console.WriteLine("  GET  {0}api/reservations - Pobierz wszystkie rezerwacje", url);
                Console.WriteLine("\nNaciśnij Ctrl+C aby zatrzymać serwer\n");

                while (true)
                {
                    var context = _listener.GetContext();
                    ProcessRequest(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd serwera: {ex.Message}");
                Console.WriteLine("\nUPEWNIJ SIĘ, ŻE:");
                Console.WriteLine("1. Uruchamiasz jako Administrator");
                Console.WriteLine("2. Port 8080 jest wolny");
            }
            finally
            {
                _listener?.Stop();
            }
        }

        private static void ProcessRequest(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;

            response.AddHeader("Access-Control-Allow-Origin", "*");
            response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            response.AddHeader("Access-Control-Allow-Headers", "Content-Type");

            try
            {
                var path = request.Url.AbsolutePath.ToLower();
                var method = request.HttpMethod;

                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {method} {path}");

                if (method == "OPTIONS")
                {
                    response.StatusCode = 200;
                    response.Close();
                    return;
                }

                if (path == "/api/reservations")
                {
                    switch (method)
                    {
                        case "POST":
                            HandlePostReservation(request, response);
                            break;
                        case "GET":
                            HandleGetReservations(response);
                            break;
                        default:
                            SendResponse(response, 405, new { error = "Method not allowed" });
                            break;
                    }
                }
                else
                {
                    SendResponse(response, 404, new { error = "Endpoint not found" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
                SendResponse(response, 500, new { error = ex.Message });
            }
        }

        private static void HandlePostReservation(HttpListenerRequest request, HttpListenerResponse response)
        {
            try
            {
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    var json = reader.ReadToEnd();
                    var reservation = JsonConvert.DeserializeObject<object>(json);

                    Reservations.Add(reservation);

                    Console.WriteLine($"? Dodano rezerwację (łącznie: {Reservations.Count})");

                    SendResponse(response, 200, new
                    {
                        success = true,
                        message = "Rezerwacja dodana pomyślnie",
                        totalReservations = Reservations.Count
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"? Błąd dodawania rezerwacji: {ex.Message}");
                SendResponse(response, 400, new { error = ex.Message });
            }
        }

        private static void HandleGetReservations(HttpListenerResponse response)
        {
            Console.WriteLine($"?? Pobrano listę rezerwacji (liczba: {Reservations.Count})");
            SendResponse(response, 200, Reservations);
        }

        private static void SendResponse(HttpListenerResponse response, int statusCode, object data)
        {
            response.StatusCode = statusCode;
            response.ContentType = "application/json";

            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            var buffer = Encoding.UTF8.GetBytes(json);

            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.Close();
        }
    }
}