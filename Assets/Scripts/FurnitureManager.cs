using UnityEngine;
using UnityEngine.XR.ARFoundation;
/*using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;*/
using UnityEngine.XR.Interaction.Toolkit.AR;


public class FurnitureManager : MonoBehaviour
{
    [SerializeField] private GameObject _furniture;
    [SerializeField] private ARPlacementInteractable _interactable;

    bool bPlaneTracking = true;
    //bool alreadySpawned = false;

    //ARRaycastManager _raycastManager;
    ARPlaneManager _planeManager;
    //List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    //GameObject _spawnedObject;


    private void Start()
    {
        //_raycastManager = GetComponent<ARRaycastManager>();
        _planeManager = GetComponent<ARPlaneManager>();
    }

    private void Update()
    {
        /*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!isButtonClicked())
            {
                if (_raycastManager.Raycast(Input.mousePosition, _hits, TrackableType.PlaneWithinPolygon) && !alreadySpawned)
                {
                    Pose pose = _hits[0].pose;
                    _spawnedObject = Instantiate(_furniture, pose.position, pose.rotation);
                    alreadySpawned = true;
                }
            }
        }*/
    }

    /*bool isButtonClicked()
    {
        if (EventSystem.current.currentSelectedGameObject?.GetComponent<Button>() == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }*/

    public void ChangeFurniture(GameObject furniture)
    {
        /*        if (alreadySpawned)
        {
            Transform _transform = _spawnedObject.transform;
            Destroy(_spawnedObject.gameObject);

            _spawnedObject = Instantiate(_interactable.placementPrefab,_transform.position, _transform.rotation);
        }*/

        _interactable.placementPrefab = furniture;
    }

    public void TogglePlaneTracking()
    {
        //ON
        if (bPlaneTracking)
        {
            _planeManager.enabled = true;
            bPlaneTracking = false;
            TogglePlanesVisibility(true);
            return;
        }

        //OFF
        TogglePlanesVisibility(false);
        _planeManager.enabled = false;
        bPlaneTracking = true;
    }

    void TogglePlanesVisibility(bool isVisible)
    {
        foreach (var plane in _planeManager.trackables)
        {
            plane.gameObject.SetActive(isVisible);
        }
    }
}

