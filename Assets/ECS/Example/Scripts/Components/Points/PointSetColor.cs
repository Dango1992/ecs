using ME.ECS;

public class PointSetColor : IComponentOnce<State, Point> {

    public UnityEngine.Color color;
    
    public Point AdvanceTick(State state, Point data, float deltaTime, int index) {

        data.color = this.color;
        return data;

    }

    void IComponent<State, Point>.CopyFrom(IComponent<State, Point> other) {

        this.color = ((PointSetColor)other).color;

    }
    
}