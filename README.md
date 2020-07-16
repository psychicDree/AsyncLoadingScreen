# AsyncLoadingScreen
 
**To avoid pauses or performance hiccups while loading, you should use the asynchronous version of Load Scene command which is: LoadSceneAsync. **

*When using "SceneManager.LoadScene" the loading does not happen immediately, it completes in the next frame. This semi-asynchronous behaviour can cause frame stuttering and can be confusing because load does not complete immediately. To overcome this problem Load Async is used.*
