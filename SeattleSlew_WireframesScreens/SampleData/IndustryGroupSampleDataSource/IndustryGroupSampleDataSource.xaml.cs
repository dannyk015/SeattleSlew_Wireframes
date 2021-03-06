﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.IndustryGroupSampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class Report { }
#else

	public class Report : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public Report()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/SeattleSlew_Wireframes.Screens;component/SampleData/IndustryGroupSampleDataSource/IndustryGroupSampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private RecordCollection _Data = new RecordCollection();

		public RecordCollection Data
		{
			get
			{
				return this._Data;
			}
		}
	}

	public class Record : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private double _IndustryGroupID = 0;

		public double IndustryGroupID
		{
			get
			{
				return this._IndustryGroupID;
			}

			set
			{
				if (this._IndustryGroupID != value)
				{
					this._IndustryGroupID = value;
					this.OnPropertyChanged("IndustryGroupID");
				}
			}
		}

		private double _IndustryGroupCode = 0;

		public double IndustryGroupCode
		{
			get
			{
				return this._IndustryGroupCode;
			}

			set
			{
				if (this._IndustryGroupCode != value)
				{
					this._IndustryGroupCode = value;
					this.OnPropertyChanged("IndustryGroupCode");
				}
			}
		}

		private string _IndustryGroupName = string.Empty;

		public string IndustryGroupName
		{
			get
			{
				return this._IndustryGroupName;
			}

			set
			{
				if (this._IndustryGroupName != value)
				{
					this._IndustryGroupName = value;
					this.OnPropertyChanged("IndustryGroupName");
				}
			}
		}

		private double _SectorID = 0;

		public double SectorID
		{
			get
			{
				return this._SectorID;
			}

			set
			{
				if (this._SectorID != value)
				{
					this._SectorID = value;
					this.OnPropertyChanged("SectorID");
				}
			}
		}
	}

	public class RecordCollection : System.Collections.ObjectModel.ObservableCollection<Record>
	{ 
	}
#endif
}
