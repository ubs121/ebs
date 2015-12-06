using System;

namespace EBS {
	public struct School {
		public int sid;
		public int rid;
		public string name;
		public string type;
		public string spec;
		public bool isbranch;
		public string note;
	}

	public struct Teacher {
		public long arcid;
		public string name;
		public int age;
		public string sex;
		public string regno;
		public int family;
		public string prof;
		public string position;
		public string degree;
		public string profdegree;
		public string education;
		public int workedyear;
	}

	public struct Equipment {
		public long arcid;
		public string equipment;
		public string type;
		public int count;
		public int acount;
		public float cost;
	}

	public struct Building {
		public long arcid;
		public string building;
		public string desc;
		public int buildyear;
		public int cardinality;
		public int roomcount;
		public string quality;
		public float cost;
		public bool available;
		public bool usingbydesc;
		public string heatingtype;
		public float heatingcapacity;
		public bool necapable;
		public bool usableinwinter;
		public bool repairneed;
		public float repaircost;
	}

	public struct Husbandry {
		public long arcid;
		public int animals;
		public int harvest;
		public float field;
		public int sheep;
		public int goat;
		public int cow;
		public int horse;
		public int camel;
		public int pig;
		public int bird;
		public int seed;
		public int vegetable;
		public int fruit;
	}
}
