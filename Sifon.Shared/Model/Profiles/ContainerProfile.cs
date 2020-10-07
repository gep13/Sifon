﻿using System.Xml;
using Sifon.Abstractions.Profiles;
using Sifon.Code.Extensions.Models;

namespace Sifon.Code.Model.Profiles
{
    internal class ContainerProfile : IContainerProfile
    {
        protected XmlNode _node;

        #region Constructors

        public ContainerProfile()
        {
        }

        public ContainerProfile(XmlNode node)
        {
            _node = node;
            this.Parse(node);
        }

        #endregion

        public bool Selected { get; set; }
        
        public string ProfileName { get; set; }
        public string Repository { get; set; }
        public string Folder { get; set; }
        public string AdminPassword { get; set; }
        public string SaPassword { get; set; }
    }
}
