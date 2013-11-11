﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.BaseRateSampleDataSource
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
				System.Uri resourceUri = new System.Uri("/SeattleSlew_Wireframes.Screens;component/SampleData/BaseRateSampleDataSource/BaseRateSampleDataSource.xaml", System.UriKind.Relative);
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

		private string _Date = string.Empty;

		public string Date
		{
			get
			{
				return this._Date;
			}

			set
			{
				if (this._Date != value)
				{
					this._Date = value;
					this.OnPropertyChanged("Date");
				}
			}
		}

		private double _Rate = 0;

		public double Rate
		{
			get
			{
				return this._Rate;
			}

			set
			{
				if (this._Rate != value)
				{
					this._Rate = value;
					this.OnPropertyChanged("Rate");
				}
			}
		}
	}

	public class RecordCollection : System.Collections.ObjectModel.ObservableCollection<Record>
	{ 
	}
#endif
}