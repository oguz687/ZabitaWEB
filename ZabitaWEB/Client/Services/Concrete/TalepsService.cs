﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;


namespace ZabitaWEB.Client.Services.Concrete
{
    public class TalepsService : ITalepsService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager navigationManager;

        public TalepsService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            this.navigationManager = navigationManager;

        }
        public Task<IActionResult> DeleteTalep(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Talep>> GetTalep(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Talep>> GetDurumTalep(string durum)
        {
            return await _httpClient.GetFromJsonAsync<List<Talep>>("/api/Taleps/durum/" + durum );
        }

        public async Task<List<Talep>> GetTaleps()
        {
            return await _httpClient.GetFromJsonAsync<List<Talep>>("/api/Taleps");
        }
        public async Task<IEnumerable<Talep>> GetTalepsEnum()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Talep>>("/api/Taleps");
           
        } 
       

        public async Task<Uri> PostTalep(Talep talep)
        {
            var response = await _httpClient.PostAsJsonAsync<Talep>("/api/Taleps", talep);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location; 
        }
        //public async void Export( Query query = null)
        //{

        //    await Task.Run(() => navigationManager.NavigateTo(query != null ? query.ToUrl($"/api/Taleps") : $"/api/Taleps", true)); 
        //}
        public async Task<StatusCodeResult> PutTalep(int id, Talep talep)
        {
            await _httpClient.PutAsJsonAsync<Talep>("/api/Taleps/" + id.ToString(), talep);
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public Task<IActionResult> Export()
        {
            throw new NotImplementedException();
        }
    }
}
