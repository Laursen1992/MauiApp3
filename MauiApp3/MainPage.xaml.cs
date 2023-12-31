﻿namespace MauiApp3;

public partial class MainPage : ContentPage
{
	int count = 0;

    private string _entryText;

    public string EntryText
    {
        get
        {
            return _entryText;
        }
        set
        {
			_entryText = value;
			OnPropertyChanged();
        }
    }

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

