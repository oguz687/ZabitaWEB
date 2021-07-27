﻿using Microsoft.AspNetCore.Mvc;
using Radzen;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface ITalepsService
    {
        Task<IActionResult> DeleteTalep(int id);
        Task<ActionResult<Talep>> GetTalep(int id);
        Task<List<Talep>> GetTaleps();
        //void Export( Query query = null);
        Task<StatusCodeResult> PutTalep(int id, Talep talep);
        Task<List<Talep>> GetDurumTalep(string durum);
        Task<IEnumerable<Talep>> GetTalepsEnum();
        Task<IActionResult> Export();
        Task<StatusCodeResult> PostTalep(Talep talep);
    }
}