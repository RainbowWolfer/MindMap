﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMap.Entities.Properties {
	public interface IProperty {
		public IProperty Translate(string json);
	}
}