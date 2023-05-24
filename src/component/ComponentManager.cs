using System;
using System.Collections.Generic;

namespace FarmLife;


public class ComponentManager
{
    private List<Component> componentList;

    public ComponentManager()
    {
        this.componentList = new List<Component>();
    }

    public void Register(Component component)
    {
        this.componentList.Add(component);
    }

    public List<Component> GetComponentList()
    {
        return this.componentList;
    }
}