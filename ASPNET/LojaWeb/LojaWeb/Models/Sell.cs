﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaWeb.Models {
	public class Sell {
		public int Id { get; set; }
		public decimal TotalPrice { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime Date { get; set; }
		public virtual ICollection<ItemSell> ItemProd { get; set; }
		public User User { get; set; }
		public int UserId { get; set; }
		public string Status { get; set; }
	}
}