﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

namespace RevitLookup.UI.Controls;

/// <summary>
/// The control that should react to changes in the screen DPI.
/// </summary>
public interface IDpiAwareControl
{
    Dpi.Dpi CurrentWindowDpi { get; }
}