//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinbook
{
    using System;
    using System.Collections.Generic;
    
    public partial class Playlist
    {
        public Playlist()
        {
            this.Tracks = new HashSet<Track>();
        }
    
        public int PlaylistId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
