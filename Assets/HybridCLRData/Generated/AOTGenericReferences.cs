public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ constraint implement type
	// }} 

	// {{ AOT generic type
	// }}

	public void RefMethods()
	{
		// System.Object LitJson.JsonMapper::ToObject<System.Object>(System.String)
		// System.Object UnityEngine.GameObject::AddComponent<System.Object>()
		// System.Object UnityEngine.Object::Instantiate<System.Object>(System.Object)
		// System.Object UnityEngine.Resources::Load<System.Object>(System.String)
	}
}