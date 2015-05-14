using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ModelViews
{
    public abstract class ModelViewBase<T>
	{
		protected T _model;

		#region Constructors

        public ModelViewBase()
        {}

		public ModelViewBase(T model)
		{
			_model = model;
		}

		#endregion Constructors

		#region Properties
		
		public T Model { get { return _model; } }

		public long Id
		{
			get
			{
				long id = 0;
				IHasId b = Model as IHasId;
				if (b != null)
					id = b.Id;
				return id;
			}
		}

		/// <summary>
		/// Name property from the Model object
		/// </summary>
		public string FullName
		{
			get
			{
				string v = string.Empty;
				IHasFullName b = Model as IHasFullName;
				if (b != null)
				{
					v = b.FullName;
				}
				return v;
			}
		}

        //TODO: convert Date.Time to readable format
        //based on users local time zone
        //public string DateLastChanged
        //{

        //}

		#endregion Properties
	}
}

