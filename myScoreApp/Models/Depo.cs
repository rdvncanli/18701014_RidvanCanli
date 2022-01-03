﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using myScoreApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Models
{
    public class Depo : IDepo
    {
        private readonly AppDbContext _appDbContext;
        public Depo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AltYorumEkle(SubComment comment)
        {
            _appDbContext.SubComments.Add(comment);
        }
        public void AltYorumSil(int id)
        {
              SubComment temp = _appDbContext.SubComments.FirstOrDefault(i => i.Id == id);
              _appDbContext.SubComments.Remove(temp);
              _appDbContext.SaveChanges();
        }
        public List<Mekan> BenimMekanlar(IdentityUser user)
        {
            var x = _appDbContext.hasta.Include(i => i.user).ToList<Mekan>();
            foreach (var i in x.ToArray())
            {
                if (i.user != user) x.Remove(i);
            }
            return x;
        }
        public void MekanEkle(Mekan mekan)
        {
            _appDbContext.hasta.Add(mekan);
            _appDbContext.SaveChanges();
        }
        public Mekan MekanGetir(int id)
        {
            return _appDbContext.hasta
                .Include(p => p.MainComments)
                    .ThenInclude(mc => mc.subComments)
                .FirstOrDefault(p => p.mekanId == id);
        }
        public MainComment YorumGetir(int id)
        {
            return _appDbContext.MainComments
                
                .FirstOrDefault(p => p.Id == id);
        }
        public SubComment AltYorumGetir(int id)
        {
            return _appDbContext.SubComments
                
                .FirstOrDefault(p => p.Id == id);
        }
        public void MekanGuncelle(int id, Mekan mekan)
        {
            var temp = MekanGetir(id);
            temp.hastalikAdi = mekan.hastalikAdi;
            temp.hastalikAciklamasi = mekan.hastalikAciklamasi;
            temp.CatName = mekan.CatName;
            temp.tarih = mekan.tarih;
            temp.hastaninAdi = mekan.hastaninAdi;
            temp.kimlikNo = mekan.kimlikNo;
            temp.numara = mekan.numara;
            temp.hastalikResmi = mekan.hastalikResmi;
            temp.doktor = mekan.doktor;
            _appDbContext.Update(temp);
            _appDbContext.SaveChanges();
        }
        public void MekanSil(int id)
        {
            Mekan temp = _appDbContext.hasta.FirstOrDefault(i => i.mekanId == id);
            _appDbContext.hasta.Remove(temp);
            _appDbContext.SaveChanges();
        }
        public async Task<bool> SaveChangesAsync()
        {
            if (await _appDbContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
        public List<Mekan> TumMekanlar()
        {
            return _appDbContext.hasta.Include(c => c.user).ToList<Mekan>();
        }
        public void YorumEkle(Mekan mekan)
        {
            _appDbContext.hasta.Update(mekan);
        }
        public void YorumSil(int id)
        {
            MainComment temp = _appDbContext.MainComments.FirstOrDefault(i => i.Id == id);
            _appDbContext.MainComments.Remove(temp);
            _appDbContext.SaveChanges();
        }
    }
}
