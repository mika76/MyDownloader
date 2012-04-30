using System;
using System.Collections.Generic;
using System.Text;
using MyDownloader.Spider.Parsers.Html;

namespace MyDownloader.Spider
{
    public delegate void ResourceCompletedEventHandler(SpiderContext context, ISpiderResource resource);

    public delegate void CompletedEventHandler(SpiderContext context);

    public class SpiderContext
    {
        private bool aborted;
        private string baseDirectory;
        private string baseLocation;

        private List<INamingRule> namingRules = new List<INamingRule>();
        private List<Uri> visitedLocations = new List<Uri>();
        private List<ISpiderResource> completedResources = new List<ISpiderResource>();

        public SpiderContext()
        {
        }

        public SpiderContext(string baseDirectory, string baseLocation)
        {
            this.baseDirectory = baseDirectory;
            this.baseLocation = baseLocation;
        }

        #region Properties

        public string BaseLocation
        {
            get
            {
                return baseLocation;
            }
            set
            {
                baseLocation = value;
            }
        }

        public string BaseDirectory
        {
            get
            {
                return baseDirectory;
            }
            set
            {
                baseDirectory = value;
            }
        }

        public List<INamingRule> NamingRules
        {
            get
            {
                return namingRules;
            }
        }

        public List<Uri> VisitedLocations
        {
            get
            {
                return visitedLocations;
            }
        }

        public List<ISpiderResource> CompletedResources
        {
            get
            {
                return completedResources;
            }
        } 

        #endregion

        #region Events

        public event ResourceCompletedEventHandler ResourceCompleted;

        public event CompletedEventHandler Completed;

        protected internal virtual void OnResourceCompleted(ISpiderResource spider)
        {
            if (ResourceCompleted != null)
            {
                ResourceCompleted(this, spider);
            }
        } 

        protected internal virtual void OnCompleted()
        {
            if (Completed != null)
            {
                Completed(this);
            }
        } 

        #endregion

        private bool ShouldAdd(Uri location, ISpiderResource parentSpider)
        {
            #region Aborted
            if (aborted)
            {
                return false;
            } 
            #endregion

            #region Naming rules
            for (int j = 0; j < namingRules.Count; j++)
            {
                if (!namingRules[j].Accept(location, this, parentSpider)) return false;
            } 
            #endregion

            return true;
        }

        public void Abort()
        {
            aborted = true;
        }

        public void NotifyCompletion(ISpiderResource spider)
        {
            lock (completedResources)
            {
                if (!completedResources.Contains(spider))
                {
                    completedResources.Add(spider);
                }
            }

            OnResourceCompleted(spider);

            if (completedResources.Count == VisitedLocations.Count)
            {
                OnCompleted();
            }
        }

        public bool AddURIToVisit(Uri uri, ISpiderResource parentSpider)
        {
            if (ShouldAdd(uri, parentSpider))
            {
                lock (visitedLocations)
                {
                    if (visitedLocations.Contains(uri))
                    {
                        return false;
                    }

                    visitedLocations.Add(uri);

                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
