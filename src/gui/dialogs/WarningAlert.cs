// created on 4/29/2005 at 2:52 PM
/*
 *   Copyright (c) 2005, Alexandros Frantzis (alf82 [at] freemail [dot] gr)
 *
 *   This file is part of Bless.
 *
 *   Bless is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 *   Bless is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with Bless; if not, write to the Free Software
 *   Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
using System;
using Gtk;

namespace Bless.Gui.Dialogs {

///<summary>An alert dialog box as recommended in the Gnome HIG</summary>
public class WarningAlert : Alert
{

	public WarningAlert(string primary, string secondary, Gtk.Window parent)
			: base(primary, secondary, parent)
	{
		image.SetFromStock(Gtk.Stock.DialogWarning, Gtk.IconSize.Dialog);

		this.AddButton(Gtk.Stock.Cancel, ResponseType.Cancel);
		this.AddButton(Gtk.Stock.Ok, ResponseType.Ok);

		this.ShowAll();
	}

}



} // namespace
