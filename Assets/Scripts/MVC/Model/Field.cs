
namespace DialogueSystem
{
    
    /// <summary>
    /// Assets are composed primarily of data elements called fields. This class represents a 
    /// field, which is a \<title, value, type\> tuple such as \<Name, Fred, Text\>. This class 
    /// also contains several static utility functions to work with fields.
    /// </summary>
    [System.Serializable]
    public class Field
    {
        /// <summary>
        /// The title of the field, such as Name or Age.
        /// </summary>
        public string title = null;
        
        /// <summary>
        /// The value of the field, such as Fred or 42.
        /// </summary>
        public string value = null;
    }
}