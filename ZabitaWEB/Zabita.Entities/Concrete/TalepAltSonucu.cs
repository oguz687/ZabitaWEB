﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class TalepAltSonucu:IEntity
    {
        [Key]
        public virtual int TalepAltSonucuId { get; set; }

        public virtual int TalepAltSonucuTipi { get; set; }
        public virtual int TalepAltSonucuIlgiliTalepTipi { get; set; }

        public virtual string TalepAltSonucuAciklama { get; set; }
        public virtual string TalepAltSonucuKapanisBilgisi { get; set; }
    }
}
