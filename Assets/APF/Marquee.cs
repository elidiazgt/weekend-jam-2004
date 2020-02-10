using UnityEngine;

public class Marquee : MonoBehaviour
{
    public string message    = "Where we're going, we don't need roads.";
    public float scrollSpeed = 50;
    public Texture image;
    Rect messageRect;
    
    void OnGUI ()
    {

        //get notifications

        // Set up the message's rect if we haven't already
        if (messageRect.width == 0) {
            Vector2 dimensions = GUI.skin.label.CalcSize(new GUIContent(message));

            //Debug.Log("x: " + dimensions.x);
            //Debug.Log("y: " + dimensions.y);
            

            // Start the message past the left side of the screen
            messageRect.x      = -dimensions.x;
            messageRect.y = 700;

            messageRect.width  =  dimensions.x * 50;
            messageRect.height = dimensions.y * 19;

        }

        //Debug.Log("Message: " + messageRect);
        messageRect.x += Time.deltaTime * scrollSpeed;
        
        // If the message has moved past the right side, move it back to the left
        if (messageRect.x > Screen.width) {
            messageRect.x = -messageRect.width;
        }
        
        //GUI.Label(messageRect, message);

       // GUI.Label(messageRect, image, message);
    }
}