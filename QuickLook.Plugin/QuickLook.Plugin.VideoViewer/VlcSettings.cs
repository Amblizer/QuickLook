﻿// Copyright © 2017 Paddy Xu
// 
// This file is part of QuickLook program.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.IO;
using System.Reflection;

namespace QuickLook.Plugin.VideoViewer
{
    public static class VlcSettings
    {
        public static string LibVlcPath = Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            App.Is64Bit ? @"LibVLC\x64" : @"LibVLC\x86");

        public static string[] VlcOptions =
        {
            "-I", "--dummy-quiet", "--ignore-config", "--no-video-title", "--no-sub-autodetect-file"
        };
    }
}