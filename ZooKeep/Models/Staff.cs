using System;
using System.Data.Entity;

namespace ZooKeep.Models {
	public enum Gender {
		male,
		female
	}
	public enum FavoriteAnimals {
		zebra,
		cat,
		anaconda,
		human,
		elephant,
		wildebeest,
		pigeon,
		crab
	}
	public class Staff {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Telephone { get; set; }
		public string Email { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public string Reason { get; set; }
		public FavoriteAnimals FavoriteAnimals { get; set; }
		public string StaffNumber { get; set; }
		public string Password { get; set; }
	}
	public class StaffDBContext : DbContext {
		public DbSet<Staff> Staffs { get; set; }
	}
}
