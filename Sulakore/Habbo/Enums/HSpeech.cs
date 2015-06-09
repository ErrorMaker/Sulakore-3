﻿/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Sulakore

    .NET library for creating Habbo Hotel related desktop applications.
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

namespace Sulakore.Habbo
{
    /// <summary>
    /// Specifies the different types of speech modes that players can communicate with each other in-game.
    /// </summary>
    public enum HSpeech
    {
        /// <summary>
        /// Represents a speech mode that makes the message publicly visible within a determined range in the room.
        /// </summary>
        Say = 0,
        /// <summary>
        /// Represents a speech mode that makes the message public to everyone in the room.
        /// </summary>
        Shout = 1,
        /// <summary>
        /// Represents a speech mode that only makes the message visible to the specified target regardless of the range.
        /// </summary>
        Whisper = 2
    }
}