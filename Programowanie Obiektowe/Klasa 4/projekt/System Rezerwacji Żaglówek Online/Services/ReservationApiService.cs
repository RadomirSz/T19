using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System_Rezerwacji_Zaglowek_Online.Models;
using System_Rezerwacji_Zaglowek_Online.Patterns;

namespace System_Rezerwacji_Zaglowek_Online.Services
{
    public class ReservationApiService
    {
        private const string API_URL = "http://localhost:8080/api/reservations";
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<bool> SendReservationAsync(Reservation reservation)
        {
            try
            {
                var json = JsonConvert.SerializeObject(reservation);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(API_URL, content);

                if (response.IsSuccessStatusCode)
                {
                    Logger.Instance.Log($"Rezerwacja {reservation.ReservationId} wys³ana do serwera");
                    return true;
                }

                Logger.Instance.Log($"B³¹d wysy³ania: {response.StatusCode}");
                return false;
            }
            catch (Exception ex)
            {
                Logger.Instance.Log($"B³¹d po³¹czenia: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Reservation>> GetReservationsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(API_URL);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Reservation>>(json);
            }
            catch (Exception ex)
            {
                Logger.Instance.Log($"B³¹d pobierania: {ex.Message}");
                return new List<Reservation>();
            }
        }

        public async Task<List<Reservation>> GetUserReservationsAsync(string userEmail)
        {
            try
            {
                var allReservations = await GetReservationsAsync();
                return allReservations.Where(r => r.User.Email == userEmail).ToList();
            }
            catch (Exception ex)
            {
                Logger.Instance.Log($"B³¹d pobierania rezerwacji u¿ytkownika: {ex.Message}");
                return new List<Reservation>();
            }
        }
    }
}