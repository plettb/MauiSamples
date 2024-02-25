﻿namespace KanbanBoard.Models;
using System.Collections.ObjectModel;

public sealed class Column
{
	public int Id { get; set; }

	public string Name { get; set; } = string.Empty;

	public int Wip { get; set; } = int.MaxValue;

	public ObservableCollection<Card> Cards { get; set; } = new();

	public int Order { get; set; }
}