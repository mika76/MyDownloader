using System;
using System.Collections.Generic;
using System.Text;
using MyDownloader.Spider.Web;
using MyDownloader.Spider.Parsers.Html;

namespace MyDownloader.Spider
{
    public class Spider
    {
        private SpiderContext context;
        private ISpiderResourceFactory factory;

        public Spider(SpiderContext context,
            ISpiderResourceFactory factory)
        {
            this.context = context;
            this.factory = factory;
        }

        #region Events

        public event EventHandler Aborted;

        public event CompletedEventHandler Completed
        {
            add
            {
                context.Completed += value;
            }
            remove
            {
                context.Completed -= value;
            }
        }

        protected virtual void OnAborted()
        {
            if (Aborted != null)
            {
                Aborted(this, EventArgs.Empty);
            }
        } 

        #endregion

        #region Properties

        public SpiderContext Context
        {
            get
            {
                return context;
            }
        } 

        #endregion

        #region Methods

        public virtual IAsyncRetriver BeginLookup()
        {
            ISpiderResource resourceSpider = factory.CreateSpider(this.context, null, this.context.BaseLocation);

            context.AddURIToVisit(new Uri(this.context.BaseLocation), resourceSpider);

            return resourceSpider.BeginReceive();
        }

        public virtual void Abort()
        {
            context.Abort();

            OnAborted();
        } 

        #endregion
    }
}