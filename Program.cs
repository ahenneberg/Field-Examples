/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FIELDS
/* A field is a variable that is a member of a class or struct. For example: */
/* Fields allow the following modifiers:
 Static modifier:       static
 Access modifiers:      public, internal, private, protected
 Inheritance modifier:  new
 Unsafe code modifier:  unsafe
 Read-only modifier:    readonly
 Threading modifier:    volatile                            */
class Octopus
{
    string name;
    //FIELD INITITALIZATION
    /* Field initialization is optional. An uninitialized field has a default value (0, \0,
      null, false). Field initializers run before constructors:  */
    public int Age = 10;
    // READONLY MODIFIER
    /* The readonly modifier prevents a field from being modified after construction.
     a read-only field can be assigned only in its declaration or within the enclosing
     type's constructor. */
    // DECLARING MULTIPLE FIELDS TOGETHER
    /* For convenience, you may declare multiple fields of the same type in a comma-
     separated list. This is a convenient way for all the fields to share the same 
     attribute and field modifiers. For example: */
    static readonly int legs = 8,
                        eyes = 2;
}

namespace Field_Examples
{
    class Program
    {
        static void Main()
        {

        }
    }
}
