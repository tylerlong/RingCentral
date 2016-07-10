using System.Threading.Tasks;
using Flurl;

namespace RingCentral
{
    public abstract partial class Model
    {
        public string _id;
        protected abstract string PathSegment { get; }
        protected Model parent;

        protected Model(Model parent, string _id = null)
        {
            this.parent = parent;
            this._id = _id;
        }

        protected virtual string Endpoint
        {
            get
            {
                var url = parent.Endpoint.AppendPathSegment(PathSegment);
                if (_id != null)
                {
                    url = url.AppendPathSegment(_id);
                }
                return url.Path;
            }
        }

        protected virtual RestClient RestClient
        {
            get
            {
                return parent.RestClient;
            }
        }

        protected Task<T> Get<T>(object queryParameters = null) where T : Model
        {
            return RestClient.Get<T>(Endpoint, queryParameters);
        }

        protected Task<T> List<T>(object queryParameters = null) where T : new()
        {
            return RestClient.Get<T>(parent.Endpoint.AppendPathSegment(PathSegment).Path, queryParameters);
        }
    }
}