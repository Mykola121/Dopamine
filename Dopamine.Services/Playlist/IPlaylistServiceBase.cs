﻿using Dopamine.Services.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dopamine.Services.Playlist
{
    public interface IPlaylistServiceBase
    {
        string PlaylistFolder { get; }

        string DialogFileFilter { get; }

        Task<AddPlaylistResult> AddPlaylistAsync(string playlistName);

        Task<DeletePlaylistsResult> DeletePlaylistAsync(PlaylistViewModel playlist);

        Task<RenamePlaylistResult> RenamePlaylistAsync(PlaylistViewModel playlistToRename, string newPlaylistName);

        Task<IList<PlaylistViewModel>> GetPlaylistsAsync();

        Task<ImportPlaylistResult> ImportPlaylistsAsync(IList<string> fileNames);

        Task<IList<TrackViewModel>> GetTracksAsync(PlaylistViewModel playlist);

        event PlaylistAddedHandler PlaylistAdded;
        event PlaylistDeletedHandler PlaylistDeleted;
        event PlaylistRenamedHandler PlaylistRenamed;
        event EventHandler PlaylistFolderChanged;
    }
}