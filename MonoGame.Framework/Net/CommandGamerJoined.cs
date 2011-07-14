using System;

namespace Microsoft.Xna.Framework.Net
{
	internal class CommandGamerJoined : ICommand
	{
		int gamerInternalIndex = -1;
		internal long remoteUniqueIdentifier = -1;
		GamerStates states;
		
		public CommandGamerJoined (int internalIndex, bool isHost, bool isLocal)
		{
			gamerInternalIndex = internalIndex;
			
			if (isHost)
				states = states | GamerStates.Host;
			if (isLocal)
				states = states | GamerStates.Local;
			
		}
		
		public CommandGamerJoined (long uniqueIndentifier)
		{
			this.remoteUniqueIdentifier = uniqueIndentifier;
			
		}		
		
		public GamerStates State
		{
			get { return states; }
		}
		
		public int InternalIndex
		{
			get { return gamerInternalIndex; }
		}
		
		public CommandEventType Command {
			get { return CommandEventType.GamerJoined; }
		}
	}
}
