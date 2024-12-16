using System;

namespace namespace_boiler {
  public delegate void NotifyEventHandler (object sender, EventArgs e);

  public class ProcessBussinessLogic {
    public event NotifyEventHandler Process
  }
}
