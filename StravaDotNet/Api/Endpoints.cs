﻿#region Copyright (C) 2014 Sascha Simon

//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see http://www.gnu.org/licenses/.
//
//  Visit the official homepage at http://www.sascha-simon.com

#endregion

using System;

namespace Strava.Api
{
    /// <summary>
    /// This static class contains the Strava API endpoint Urls.
    /// </summary>
    public static class Endpoints
    {
        /// <summary>
        /// Url to the Activity endpoint used for the currently authenticated athlete.
        /// </summary>
        public const string Activity = "https://www.strava.com/api/v3/activities";
        /// <summary>
        /// Url to the Activity endpoint used for other athletes than the currently authenticated one.
        /// </summary>
        public const string Activities = "https://www.strava.com/api/v3/athlete/activities";
        /// <summary>
        /// Url to the Followers endpoint.
        /// </summary>
        public const string ActivitiesFollowers = "https://www.strava.com/api/v3/activities/following";
        /// <summary>
        /// Url to the Athlete endpoint used for the currently authenticated athlete.
        /// </summary>
        public const string Athlete = "https://www.strava.com/api/v3/athlete";
        /// <summary>
        /// Url to the Athlete endpoint used for other athletes than the currently authenticated one.
        /// </summary>
        public const string Athletes = "https://www.strava.com/api/v3/athletes";
        /// <summary>
        /// Url to the Club endpoint used for other athletes than the currently authenticated one.
        /// </summary>
        public const string Club = "https://www.strava.com/api/v3/clubs";
        /// <summary>
        /// Url to the Club endpoint used for the currently authenticated athlete.
        /// </summary>
        public const string Clubs = "https://www.strava.com/api/v3/athlete/clubs";
        /// <summary>
        /// Url to the endpoint used for receiving the friends of the currentlx authenticated user.
        /// </summary>
        public const string Friends = "https://www.strava.com/api/v3/athlete/friends";
        /// <summary>
        /// Url to the endpoint used for receiving the followers of the currently authenticated athlete.
        /// </summary>
        public const string Follower = "https://www.strava.com/api/v3/athlete/followers";
        /// <summary>
        /// Url to the endpoint used for receiving the followers of athletes other than the currently authenticated one.
        /// </summary>
        public const string Followers = "https://www.strava.com/api/v3/athletes";
        /// <summary>
        /// Url to the endpoint used for receiving gear.
        /// </summary>
        public const string Gear = "https://www.strava.com/api/v3/gear";
        /// <summary>
        /// Url to the endpoint used for receiving segment information.
        /// </summary>
        public const string Leaderboard = "https://www.strava.com/api/v3/segments";
        /// <summary>
        /// Url to the endpoint used for receiving starred segments.
        /// </summary>
        public const string Starred = "https://www.strava.com/api/v3/segments/starred";
        /// <summary>
        /// Url to the endpoint used for uploads.
        /// </summary>
        public const string Uploads = "https://www.strava.com/api/v3/uploads/";
        /// <summary>
        /// Url to the Routes endpoint used for the currently authenticated athlete.
        /// </summary>
        public const string Routes = "https://www.strava.com/api/v3/athletes/{0}/routes";
        /// <summary>
        /// Url to the Routes endpoint used for the currently authenticated athlete.
        /// </summary>
        public const string Route = "https://www.strava.com/api/v3/routes/";
        
    }
}
