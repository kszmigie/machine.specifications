namespace Machine.Specifications.DevelopWithPassion.DSL.FieldSwitching
{
    public interface MemberTarget
    {
        object get_value();
        void change_value_to(object new_value);
    }
}