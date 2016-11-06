namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class beaten_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar6 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable0 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				Blackboards.personality StoredVariable1 = ((Blackboards.personality)StoredVariable0.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable1 != null)
				{
					Blackboards.aged StoredVariable2 = ((Blackboards.aged)StoredVariable1.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable2 != null)
					{
						System.Boolean ifResult3; //IsContext = False IsNew = False
						
						System.Int32 OperandVar5 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop4 = StoredVariable2.CurAge; //IsContext = False IsNew = False
						OperandVar5 = prop4;
						
						
						if(ifResult3 = ( ( (OperandVar5))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar6 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar6);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject beaten_as_a_kid = new UnityEngine.GameObject("beaten_as_a_kid"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject beaten_as_a_kid7 = beaten_as_a_kid; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext8 = (Blackboards.targeted_event)beaten_as_a_kid.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext8 ContextSwitchInterpreter
					if(AddContext8 != null)
					{
						UnityEngine.GameObject OperandVar9 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar9 = root;
						AddContext8.Target = (UnityEngine.GameObject)( (OperandVar9));
					}
				}
			}
			
			{
				Blackboards.aged subContext10 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext10 ContextSwitchInterpreter
				if(subContext10 != null)
				{
					
					System.Int32 OperandVar12 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop11 = subContext10.CurAge; //IsContext = False IsNew = False
					OperandVar12 = prop11;
					
					
					subContext10.CurAge = (System.Int32)(( ( (OperandVar12))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext13 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext13 ContextSwitchInterpreter
				if(subContext13 != null)
				{
					
					System.Single OperandVar15 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop14 = subContext13.Cruel; //IsContext = False IsNew = False
					OperandVar15 = prop14;
					
					
					subContext13.Cruel = (System.Single)(( ( (OperandVar15))) + ( ( (0.1f))));
					
					System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop16 = subContext13.Reckless; //IsContext = False IsNew = False
					OperandVar17 = prop16;
					
					
					subContext13.Reckless = (System.Single)(( ( (OperandVar17))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class cherished_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar24 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable18 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable18 != null)
			{
				Blackboards.personality StoredVariable19 = ((Blackboards.personality)StoredVariable18.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable19 != null)
				{
					Blackboards.aged StoredVariable20 = ((Blackboards.aged)StoredVariable19.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable20 != null)
					{
						System.Boolean ifResult21; //IsContext = False IsNew = False
						
						System.Int32 OperandVar23 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop22 = StoredVariable20.CurAge; //IsContext = False IsNew = False
						OperandVar23 = prop22;
						
						
						if(ifResult21 = ( ( (OperandVar23))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar24 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar24);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject cherished_as_a_kid = new UnityEngine.GameObject("cherished_as_a_kid"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cherished_as_a_kid25 = cherished_as_a_kid; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext26 = (Blackboards.targeted_event)cherished_as_a_kid.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext26 ContextSwitchInterpreter
					if(AddContext26 != null)
					{
						UnityEngine.GameObject OperandVar27 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar27 = root;
						AddContext26.Target = (UnityEngine.GameObject)( (OperandVar27));
					}
				}
			}
			
			{
				Blackboards.aged subContext28 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext28 ContextSwitchInterpreter
				if(subContext28 != null)
				{
					
					System.Int32 OperandVar30 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop29 = subContext28.CurAge; //IsContext = False IsNew = False
					OperandVar30 = prop29;
					
					
					subContext28.CurAge = (System.Int32)(( ( (OperandVar30))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext31 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext31 ContextSwitchInterpreter
				if(subContext31 != null)
				{
					
					System.Single OperandVar33 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop32 = subContext31.Brave; //IsContext = False IsNew = False
					OperandVar33 = prop32;
					
					
					subContext31.Brave = (System.Single)(( ( (OperandVar33))) - ( ( (0.1f))));
					
					System.Single OperandVar35 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop34 = subContext31.Optimistic; //IsContext = False IsNew = False
					OperandVar35 = prop34;
					
					
					subContext31.Optimistic = (System.Single)(( ( (OperandVar35))) + ( ( (0.2f))));
					
					System.Single OperandVar37 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop36 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar37 = prop36;
					
					
					if(( ( (OperandVar37))) > ( ( (0.9f))))
					{
						
						System.Single OperandVar39 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop38 = subContext31.Cruel; //IsContext = False IsNew = False
						OperandVar39 = prop38;
						
						
						subContext31.Cruel = (System.Single)(( ( (OperandVar39))) + ( ( (0.1f))));
					}
					
					System.Single OperandVar41 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop40 = subContext31.Ambitious; //IsContext = False IsNew = False
					OperandVar41 = prop40;
					
					
					subContext31.Ambitious = (System.Single)(( ( (OperandVar41))) - ( ( (0.03f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class inspired_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar48 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable42 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable42 != null)
			{
				Blackboards.personality StoredVariable43 = ((Blackboards.personality)StoredVariable42.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable43 != null)
				{
					Blackboards.aged StoredVariable44 = ((Blackboards.aged)StoredVariable43.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable44 != null)
					{
						System.Boolean ifResult45; //IsContext = False IsNew = False
						
						System.Int32 OperandVar47 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop46 = StoredVariable44.CurAge; //IsContext = False IsNew = False
						OperandVar47 = prop46;
						
						
						if(ifResult45 = ( ( (OperandVar47))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar48 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar48);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject inspired_as_a_kid = new UnityEngine.GameObject("inspired_as_a_kid"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject inspired_as_a_kid49 = inspired_as_a_kid; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext50 = (Blackboards.targeted_event)inspired_as_a_kid.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext50 ContextSwitchInterpreter
					if(AddContext50 != null)
					{
						UnityEngine.GameObject OperandVar51 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar51 = root;
						AddContext50.Target = (UnityEngine.GameObject)( (OperandVar51));
					}
				}
			}
			
			{
				Blackboards.aged subContext52 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext52 ContextSwitchInterpreter
				if(subContext52 != null)
				{
					
					System.Int32 OperandVar54 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop53 = subContext52.CurAge; //IsContext = False IsNew = False
					OperandVar54 = prop53;
					
					
					subContext52.CurAge = (System.Int32)(( ( (OperandVar54))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext55 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext55 ContextSwitchInterpreter
				if(subContext55 != null)
				{
					
					System.Single OperandVar57 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop56 = subContext55.Brave; //IsContext = False IsNew = False
					OperandVar57 = prop56;
					
					
					subContext55.Brave = (System.Single)(( ( (OperandVar57))) + ( ( (0.2f))));
					
					System.Single OperandVar59 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop58 = subContext55.Optimistic; //IsContext = False IsNew = False
					OperandVar59 = prop58;
					
					
					subContext55.Optimistic = (System.Single)(( ( (OperandVar59))) + ( ( (0.5f))));
					
					System.Single OperandVar61 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop60 = subContext55.Ambitious; //IsContext = False IsNew = False
					OperandVar61 = prop60;
					
					
					subContext55.Ambitious = (System.Single)(( ( (OperandVar61))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class taught_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar68 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable62 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable62 != null)
			{
				Blackboards.personality StoredVariable63 = ((Blackboards.personality)StoredVariable62.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable63 != null)
				{
					Blackboards.aged StoredVariable64 = ((Blackboards.aged)StoredVariable63.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable64 != null)
					{
						System.Boolean ifResult65; //IsContext = False IsNew = False
						
						System.Int32 OperandVar67 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop66 = StoredVariable64.CurAge; //IsContext = False IsNew = False
						OperandVar67 = prop66;
						
						
						if(ifResult65 = ( ( (OperandVar67))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar68 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar68);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject teached_as_a_kid = new UnityEngine.GameObject("teached_as_a_kid"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject teached_as_a_kid69 = teached_as_a_kid; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext70 = (Blackboards.targeted_event)teached_as_a_kid.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext70 ContextSwitchInterpreter
					if(AddContext70 != null)
					{
						UnityEngine.GameObject OperandVar71 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar71 = root;
						AddContext70.Target = (UnityEngine.GameObject)( (OperandVar71));
					}
				}
			}
			
			{
				Blackboards.aged subContext72 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext72 ContextSwitchInterpreter
				if(subContext72 != null)
				{
					
					System.Int32 OperandVar74 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop73 = subContext72.CurAge; //IsContext = False IsNew = False
					OperandVar74 = prop73;
					
					
					subContext72.CurAge = (System.Int32)(( ( (OperandVar74))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext75 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext75 ContextSwitchInterpreter
				if(subContext75 != null)
				{
					
					System.Single OperandVar77 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop76 = subContext75.Rational; //IsContext = False IsNew = False
					OperandVar77 = prop76;
					
					
					subContext75.Rational = (System.Single)(( ( (OperandVar77))) + ( ( (0.1f))));
					
					System.Single OperandVar79 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop78 = subContext75.Ambitious; //IsContext = False IsNew = False
					OperandVar79 = prop78;
					
					
					subContext75.Ambitious = (System.Single)(( ( (OperandVar79))) + ( ( (0.05f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class pushy_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar86 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable80 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable80 != null)
			{
				Blackboards.personality StoredVariable81 = ((Blackboards.personality)StoredVariable80.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable81 != null)
				{
					Blackboards.aged StoredVariable82 = ((Blackboards.aged)StoredVariable81.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable82 != null)
					{
						System.Boolean ifResult83; //IsContext = False IsNew = False
						
						System.Int32 OperandVar85 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop84 = StoredVariable82.CurAge; //IsContext = False IsNew = False
						OperandVar85 = prop84;
						
						
						if(ifResult83 = ( ( (OperandVar85))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar86 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar86);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar89 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable87 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable87 != null)
			{
				System.Single prop88 = StoredVariable87.Brave; //IsContext = False IsNew = False
				OperandVar89 = prop88;
			}
			
			System.Single OperandVar91 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable87 != null)
			{
				System.Single prop90 = StoredVariable87.Ambitious; //IsContext = False IsNew = False
				OperandVar91 = prop90;
			}
			
			System.Single OperandVar93 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable87 != null)
			{
				System.Single prop92 = StoredVariable87.Cruel; //IsContext = False IsNew = False
				OperandVar93 = prop92;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar89))) + ( ( (OperandVar91))) - ( ( (OperandVar93)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject pushy_teen = new UnityEngine.GameObject("pushy_teen"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject pushy_teen94 = pushy_teen; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext95 = (Blackboards.targeted_event)pushy_teen.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext95 ContextSwitchInterpreter
					if(AddContext95 != null)
					{
						UnityEngine.GameObject OperandVar96 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar96 = root;
						AddContext95.Target = (UnityEngine.GameObject)( (OperandVar96));
					}
				}
			}
			
			{
				Blackboards.aged subContext97 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext97 ContextSwitchInterpreter
				if(subContext97 != null)
				{
					
					System.Int32 OperandVar99 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop98 = subContext97.CurAge; //IsContext = False IsNew = False
					OperandVar99 = prop98;
					
					System.Single OperandVar101 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop100 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar101 = prop100;
					subContext97.CurAge = (System.Int32)(( ( (OperandVar99))) + ( ( (OperandVar101))));
				}
			}
			
			{
				Blackboards.personality subContext102 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext102 ContextSwitchInterpreter
				if(subContext102 != null)
				{
					
					System.Single OperandVar104 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop103 = subContext102.Brave; //IsContext = False IsNew = False
					OperandVar104 = prop103;
					
					
					subContext102.Brave = (System.Single)(( ( (OperandVar104))) + ( ( (0.3f))));
					
					System.Single OperandVar106 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop105 = subContext102.Rational; //IsContext = False IsNew = False
					OperandVar106 = prop105;
					
					
					subContext102.Rational = (System.Single)(( ( (OperandVar106))) - ( ( (0.1f))));
					
					System.Single OperandVar108 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop107 = subContext102.Optimistic; //IsContext = False IsNew = False
					OperandVar108 = prop107;
					
					
					subContext102.Optimistic = (System.Single)(( ( (OperandVar108))) + ( ( (0.3f))));
					
					System.Single OperandVar110 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop109 = subContext102.Ambitious; //IsContext = False IsNew = False
					OperandVar110 = prop109;
					
					
					subContext102.Ambitious = (System.Single)(( ( (OperandVar110))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class nerd_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar117 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable111 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable111 != null)
			{
				Blackboards.personality StoredVariable112 = ((Blackboards.personality)StoredVariable111.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable112 != null)
				{
					Blackboards.aged StoredVariable113 = ((Blackboards.aged)StoredVariable112.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable113 != null)
					{
						System.Boolean ifResult114; //IsContext = False IsNew = False
						
						System.Int32 OperandVar116 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop115 = StoredVariable113.CurAge; //IsContext = False IsNew = False
						OperandVar116 = prop115;
						
						
						if(ifResult114 = ( ( (OperandVar116))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar117 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar117);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar120 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable118 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable118 != null)
			{
				System.Single prop119 = StoredVariable118.Rational; //IsContext = False IsNew = False
				OperandVar120 = prop119;
			}
			
			System.Single OperandVar122 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable118 != null)
			{
				System.Single prop121 = StoredVariable118.Brave; //IsContext = False IsNew = False
				OperandVar122 = prop121;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar120))) - ( ( (OperandVar122)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject nerd_teen = new UnityEngine.GameObject("nerd_teen"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject nerd_teen123 = nerd_teen; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext124 = (Blackboards.targeted_event)nerd_teen.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext124 ContextSwitchInterpreter
					if(AddContext124 != null)
					{
						UnityEngine.GameObject OperandVar125 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar125 = root;
						AddContext124.Target = (UnityEngine.GameObject)( (OperandVar125));
					}
				}
			}
			
			{
				Blackboards.aged subContext126 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext126 ContextSwitchInterpreter
				if(subContext126 != null)
				{
					
					System.Int32 OperandVar128 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop127 = subContext126.CurAge; //IsContext = False IsNew = False
					OperandVar128 = prop127;
					
					System.Single OperandVar130 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop129 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar130 = prop129;
					subContext126.CurAge = (System.Int32)(( ( (OperandVar128))) + ( ( (OperandVar130))));
				}
			}
			
			{
				Blackboards.personality subContext131 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext131 ContextSwitchInterpreter
				if(subContext131 != null)
				{
					
					System.Single OperandVar133 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop132 = subContext131.Brave; //IsContext = False IsNew = False
					OperandVar133 = prop132;
					
					
					subContext131.Brave = (System.Single)(( ( (OperandVar133))) - ( ( (0.1f))));
					
					System.Single OperandVar135 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop134 = subContext131.Rational; //IsContext = False IsNew = False
					OperandVar135 = prop134;
					
					
					subContext131.Rational = (System.Single)(( ( (OperandVar135))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class manipulative_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar142 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable136 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable136 != null)
			{
				Blackboards.personality StoredVariable137 = ((Blackboards.personality)StoredVariable136.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable137 != null)
				{
					Blackboards.aged StoredVariable138 = ((Blackboards.aged)StoredVariable137.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable138 != null)
					{
						System.Boolean ifResult139; //IsContext = False IsNew = False
						
						System.Int32 OperandVar141 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop140 = StoredVariable138.CurAge; //IsContext = False IsNew = False
						OperandVar141 = prop140;
						
						
						if(ifResult139 = ( ( (OperandVar141))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar142 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar142);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar145 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable143 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable143 != null)
			{
				System.Single prop144 = StoredVariable143.Rational; //IsContext = False IsNew = False
				OperandVar145 = prop144;
			}
			
			System.Single OperandVar147 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable143 != null)
			{
				System.Single prop146 = StoredVariable143.Ambitious; //IsContext = False IsNew = False
				OperandVar147 = prop146;
			}
			
			return (System.Single)( ( (0.2f))) + ( ( (OperandVar145))) + ( (( (OperandVar147)) * ( (2f))));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject manipulative_teen = new UnityEngine.GameObject("manipulative_teen"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject manipulative_teen148 = manipulative_teen; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext149 = (Blackboards.targeted_event)manipulative_teen.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext149 ContextSwitchInterpreter
					if(AddContext149 != null)
					{
						UnityEngine.GameObject OperandVar150 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar150 = root;
						AddContext149.Target = (UnityEngine.GameObject)( (OperandVar150));
					}
				}
			}
			
			{
				Blackboards.aged subContext151 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext151 ContextSwitchInterpreter
				if(subContext151 != null)
				{
					
					System.Int32 OperandVar153 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop152 = subContext151.CurAge; //IsContext = False IsNew = False
					OperandVar153 = prop152;
					
					System.Single OperandVar155 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop154 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar155 = prop154;
					subContext151.CurAge = (System.Int32)(( ( (OperandVar153))) + ( ( (OperandVar155))));
				}
			}
			
			{
				Blackboards.personality subContext156 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext156 ContextSwitchInterpreter
				if(subContext156 != null)
				{
					
					System.Single OperandVar158 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop157 = subContext156.Brave; //IsContext = False IsNew = False
					OperandVar158 = prop157;
					
					
					subContext156.Brave = (System.Single)(( ( (OperandVar158))) - ( ( (0.2f))));
					
					System.Single OperandVar160 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop159 = subContext156.Ambitious; //IsContext = False IsNew = False
					OperandVar160 = prop159;
					
					
					subContext156.Ambitious = (System.Single)(( ( (OperandVar160))) + ( ( (0.3f))));
					
					System.Single OperandVar162 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop161 = subContext156.Reckless; //IsContext = False IsNew = False
					OperandVar162 = prop161;
					
					
					subContext156.Reckless = (System.Single)(( ( (OperandVar162))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true)]
    public class tortured_pets_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar169 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable163 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable163 != null)
			{
				Blackboards.personality StoredVariable164 = ((Blackboards.personality)StoredVariable163.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable164 != null)
				{
					Blackboards.aged StoredVariable165 = ((Blackboards.aged)StoredVariable164.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable165 != null)
					{
						System.Boolean ifResult166; //IsContext = False IsNew = False
						
						System.Int32 OperandVar168 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop167 = StoredVariable165.CurAge; //IsContext = False IsNew = False
						OperandVar168 = prop167;
						
						
						if(ifResult166 = ( ( (OperandVar168))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar169 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar169);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar172 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable170 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable170 != null)
			{
				System.Single prop171 = StoredVariable170.Cruel; //IsContext = False IsNew = False
				OperandVar172 = prop171;
			}
			
			return (System.Single)( (OperandVar172)) * ( (0.8f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject tortured_pets_teen = new UnityEngine.GameObject("tortured_pets_teen"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject tortured_pets_teen173 = tortured_pets_teen; //IsContext = True IsNew = False
				Blackboards.targeted_event AddContext174 = (Blackboards.targeted_event)tortured_pets_teen.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext174 ContextSwitchInterpreter
					if(AddContext174 != null)
					{
						UnityEngine.GameObject OperandVar175 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar175 = root;
						AddContext174.Target = (UnityEngine.GameObject)( (OperandVar175));
					}
				}
			}
			
			{
				Blackboards.aged subContext176 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext176 ContextSwitchInterpreter
				if(subContext176 != null)
				{
					
					System.Int32 OperandVar178 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop177 = subContext176.CurAge; //IsContext = False IsNew = False
					OperandVar178 = prop177;
					
					System.Single OperandVar180 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop179 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar180 = prop179;
					subContext176.CurAge = (System.Int32)(( ( (OperandVar178))) + ( ( (OperandVar180))));
				}
			}
			
			{
				Blackboards.personality subContext181 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext181 ContextSwitchInterpreter
				if(subContext181 != null)
				{
					
					System.Single OperandVar183 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop182 = subContext181.Rational; //IsContext = False IsNew = False
					OperandVar183 = prop182;
					
					
					subContext181.Rational = (System.Single)(( ( (OperandVar183))) - ( ( (0.1f))));
					
					System.Single OperandVar185 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop184 = subContext181.Cruel; //IsContext = False IsNew = False
					OperandVar185 = prop184;
					
					
					subContext181.Cruel = (System.Single)(( ( (OperandVar185))) + ( ( (0.5f))));
					
					System.Single OperandVar187 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop186 = subContext181.Reckless; //IsContext = False IsNew = False
					OperandVar187 = prop186;
					
					
					subContext181.Reckless = (System.Single)(( ( (OperandVar187))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="conflict_decomposition", OncePerObject=true, OncePerTurn=false)]
    public class war_conflict : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar189 = default(System.Boolean); //IsContext = False IsNew = False
			Conflict StoredVariable188 = ((Conflict)root.GetComponent(typeof(Conflict))); //IsContext = False IsNew = False
			if(StoredVariable188 != null)
			{
				applicable = true;
				OperandVar189 = applicable;
			}
			return (System.Boolean) (OperandVar189);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject first_foe = new UnityEngine.GameObject("first_foe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject first_foe190 = first_foe; //IsContext = True IsNew = False
				Entity AddContext191 = (Entity)first_foe.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.foe_role AddContext192 = (Blackboards.foe_role)first_foe.AddComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = True
				Actor AddContext193 = (Actor)first_foe.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(first_foe, 0.1f);
			UnityEngine.GameObject second_foe = new UnityEngine.GameObject("second_foe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject second_foe194 = second_foe; //IsContext = True IsNew = False
				Entity AddContext195 = (Entity)second_foe.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Actor AddContext196 = (Actor)second_foe.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.foe_role AddContext197 = (Blackboards.foe_role)second_foe.AddComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.foe_role AddContext197 ContextSwitchInterpreter
					if(AddContext197 != null)
					{
						UnityEngine.GameObject OperandVar198 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar198 = first_foe;
						AddContext197.Enemy = (UnityEngine.GameObject)( (OperandVar198));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(second_foe, 0.1f);
			
			{
				UnityEngine.GameObject subContext199 = first_foe; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext199 ContextPropertySwitchInterpreter
				if(subContext199 != null)
				{
					
					{
						Blackboards.foe_role subContext200 = (Blackboards.foe_role)subContext199.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
						//ContextStatement Blackboards.foe_role subContext200 ContextSwitchInterpreter
						if(subContext200 != null)
						{
							UnityEngine.GameObject OperandVar201 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar201 = second_foe;
							subContext200.Enemy = (UnityEngine.GameObject)( (OperandVar201));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="foe_decomposition", OncePerObject=true, OncePerTurn=false)]
    public class foe_is_ruler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar203 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable202 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable202 != null)
			{
				applicable = true;
				OperandVar203 = applicable;
			}
			return (System.Boolean) (OperandVar203);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Blackboards.ruler_role ContextVar204 = root.AddComponent<Blackboards.ruler_role>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.ruler_role ContextVar204 ContextSwitchInterpreter
				if(ContextVar204 != null)
				{
					System.Single OperandVar206 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop205 = External.Random( (10f), (20f)); //IsContext = False IsNew = False
					OperandVar206 = prop205;
					ContextVar204.Forces = (System.Single)( (OperandVar206));
					
					ContextVar204.People = (System.Single)( (1f));
				}
			}
			Entity EntVar207 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar207 != null) EntVar207.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class ruler_as_person : EventAction {
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar210 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable208 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable208 != null)
			{
				Markers StoredVariable209 = ((Markers)StoredVariable208.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable209 != null)
				{
					applicable = true;
					OperandVar210 = applicable;
				}
			}
			return (System.Boolean) (OperandVar210);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext211 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext211 ContextSwitchInterpreter
				if(subContext211 != null)
				{
					System.String OperandVar212 = default(System.String); //IsContext = False IsNew = False
					OperandVar212 = "is_person";
					subContext211.SetMarker(( (OperandVar212)).ToString());
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class genius_as_person : EventAction {
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar216 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.worker StoredVariable213 = ((Blackboards.worker)root.GetComponent(typeof(Blackboards.worker))); //IsContext = False IsNew = False
			if(StoredVariable213 != null)
			{
				Blackboards.builder StoredVariable214 = ((Blackboards.builder)StoredVariable213.GetComponent(typeof(Blackboards.builder))); //IsContext = False IsNew = False
				if(StoredVariable214 != null)
				{
					Markers StoredVariable215 = ((Markers)StoredVariable214.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
					if(StoredVariable215 != null)
					{
						applicable = true;
						OperandVar216 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar216);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext217 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext217 ContextSwitchInterpreter
				if(subContext217 != null)
				{
					System.String OperandVar218 = default(System.String); //IsContext = False IsNew = False
					OperandVar218 = "is_person";
					subContext217.SetMarker(( (OperandVar218)).ToString());
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class as_person : EventAction {
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar224 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable219 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable219 != null)
			{
				System.Boolean ifResult220; //IsContext = False IsNew = False
				System.Boolean OperandVar223 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar221 = default(System.String); //IsContext = False IsNew = False
				OperandVar221 = "is_person";
				System.Boolean prop222 = StoredVariable219.HasMarker( (OperandVar221)); //IsContext = False IsNew = False
				OperandVar223 = prop222;
				if(ifResult220 =  (OperandVar223))
				{
					applicable = true;
					OperandVar224 = applicable;
				}
			}
			return (System.Boolean) (OperandVar224);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Blackboards.aged ContextVar225 = root.AddComponent<Blackboards.aged>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.aged ContextVar225 ContextSwitchInterpreter
				if(ContextVar225 != null)
				{
					System.Single OperandVar227 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop226 = External.Random( (30f), (60f)); //IsContext = False IsNew = False
					OperandVar227 = prop226;
					ContextVar225.Age = (System.Int32)( (OperandVar227));
				}
			}
			Entity EntVar228 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			
			Blackboards.attributes ContextVar229 = root.AddComponent<Blackboards.attributes>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.attributes ContextVar229 ContextSwitchInterpreter
				if(ContextVar229 != null)
				{
					System.Single OperandVar231 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop230 = External.Random( (1f), (10f)); //IsContext = False IsNew = False
					OperandVar231 = prop230;
					ContextVar229.Charisma = (System.Int32)( (OperandVar231));
					System.Single OperandVar233 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop232 = External.Random( (1f), (10f)); //IsContext = False IsNew = False
					OperandVar233 = prop232;
					ContextVar229.Intellect = (System.Int32)( (OperandVar233));
					System.Single OperandVar235 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop234 = External.Random( (1f), (10f)); //IsContext = False IsNew = False
					OperandVar235 = prop234;
					ContextVar229.Military = (System.Int32)( (OperandVar235));
					System.Single OperandVar237 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop236 = External.Random( (1f), (10f)); //IsContext = False IsNew = False
					OperandVar237 = prop236;
					ContextVar229.Mental = (System.Int32)( (OperandVar237));
					System.Single OperandVar239 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop238 = External.Random( (1f), (10f)); //IsContext = False IsNew = False
					OperandVar239 = prop238;
					ContextVar229.Health = (System.Int32)( (OperandVar239));
				}
			}
			
			Blackboards.personality ContextVar240 = root.AddComponent<Blackboards.personality>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.personality ContextVar240 ContextSwitchInterpreter
				if(ContextVar240 != null)
				{
					System.Single OperandVar242 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop241 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar242 = prop241;
					ContextVar240.Brave = (System.Single)( (OperandVar242));
					System.Single OperandVar244 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop243 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar244 = prop243;
					ContextVar240.Rational = (System.Single)( (OperandVar244));
					System.Single OperandVar246 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop245 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar246 = prop245;
					ContextVar240.Optimistic = (System.Single)( (OperandVar246));
					System.Single OperandVar248 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop247 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar248 = prop247;
					ContextVar240.Cruel = (System.Single)( (OperandVar248));
					System.Single OperandVar250 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop249 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar250 = prop249;
					ContextVar240.Ambitious = (System.Single)( (OperandVar250));
					System.Single OperandVar252 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop251 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar252 = prop251;
					ContextVar240.Reckless = (System.Single)( (OperandVar252));
				}
			}
			if(EntVar228 != null) EntVar228.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true)]
    public class ruler_vs_ruler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar262 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable253 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable253 != null)
			{
				Blackboards.foe_role StoredVariable254 = ((Blackboards.foe_role)StoredVariable253.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
				if(StoredVariable254 != null)
				{
					Blackboards.ruler_role StoredVariable255 = ((Blackboards.ruler_role)StoredVariable254.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable255 != null)
					{
						System.Boolean ifResult256; //IsContext = False IsNew = False
						
						System.Boolean OperandVar259 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable254 != null)
						{
							UnityEngine.GameObject prop257 = StoredVariable254.Enemy; //IsContext = False IsNew = False
							if(prop257 != null)
							{
								Blackboards.ruler_role StoredVariable258 = ((Blackboards.ruler_role)prop257.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable258 != null)
								{
									applicable = true;
									OperandVar259 = applicable;
								}
							}
						}
						
						System.Boolean OperandVar261 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable253 != null)
						{
							System.Boolean prop260 = StoredVariable253.IsActive; //IsContext = False IsNew = False
							OperandVar261 = prop260;
						}
						if(ifResult256 = ( ( (OperandVar259))) && ( (!(OperandVar261))))
						{
							applicable = true;
							OperandVar262 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar262);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.Single OperandVar265 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable263 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable263 != null)
			{
				System.Single prop264 = StoredVariable263.Forces; //IsContext = False IsNew = False
				OperandVar265 = prop264;
			}
			System.Single my_forces =  (OperandVar265); //IsContext = False IsNew = False
			System.Single OperandVar270 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable266 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable266 != null)
			{
				UnityEngine.GameObject prop267 = StoredVariable266.Enemy; //IsContext = False IsNew = False
				if(prop267 != null)
				{
					Blackboards.ruler_role StoredVariable268 = ((Blackboards.ruler_role)prop267.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable268 != null)
					{
						System.Single prop269 = StoredVariable268.Forces; //IsContext = False IsNew = False
						OperandVar270 = prop269;
					}
				}
			}
			System.Single enemy_forces =  (OperandVar270); //IsContext = False IsNew = False
			
			{
				Blackboards.foe_role subContext271 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext271 ContextSwitchInterpreter
				if(subContext271 != null)
				{
					
					
					System.Single OperandVar272 = default(System.Single); //IsContext = False IsNew = False
					OperandVar272 = my_forces;
					
					
					if(!(( ( (OperandVar272))) == ( ( (0f)))))
					{
						System.Single OperandVar273 = default(System.Single); //IsContext = False IsNew = False
						OperandVar273 = enemy_forces;
						System.Single OperandVar274 = default(System.Single); //IsContext = False IsNew = False
						OperandVar274 = my_forces;
						subContext271.ThreatLevel = (System.Single)(( (OperandVar273)) / ( (OperandVar274)));
					}
					
					
					System.Single OperandVar275 = default(System.Single); //IsContext = False IsNew = False
					OperandVar275 = my_forces;
					
					
					
					
					System.Single OperandVar277 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop276 = subContext271.ThreatLevel; //IsContext = False IsNew = False
					OperandVar277 = prop276;
					
					
					if(( (( ( (OperandVar275))) == ( ( (0f))))) || ( (( ( (OperandVar277))) > ( ( (1000f))))))
					{
						
						subContext271.ThreatLevel = (System.Single)( (1000f));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class start_a_war : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar297 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable278 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable278 != null)
			{
				Blackboards.foe_role StoredVariable279 = ((Blackboards.foe_role)StoredVariable278.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
				if(StoredVariable279 != null)
				{
					Blackboards.ruler_role StoredVariable280 = ((Blackboards.ruler_role)StoredVariable279.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable280 != null)
					{
						System.Boolean ifResult281; //IsContext = False IsNew = False
						
						System.Boolean OperandVar288 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable279 != null)
						{
							UnityEngine.GameObject prop282 = StoredVariable279.Enemy; //IsContext = False IsNew = False
							if(prop282 != null)
							{
								System.Boolean ifResult283; //IsContext = False IsNew = False
								System.Boolean OperandVar287 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.ruler_role OperandVar285 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
								Blackboards.ruler_role StoredVariable284 = ((Blackboards.ruler_role)prop282.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable284 != null)
								{
									OperandVar285 = StoredVariable284;
								}
								System.Boolean prop286 = External.Has( (OperandVar285)); //IsContext = False IsNew = False
								OperandVar287 = prop286;
								if(ifResult283 =  (OperandVar287))
								{
									OperandVar288 = ifResult283;
								}
							}
						}
						
						System.Boolean OperandVar294 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar290 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> prop289 = StoredVariable280.AtWarWith; //IsContext = False IsNew = False
						if(prop289 != null)
						{
							OperandVar290 = prop289;
						}
						UnityEngine.GameObject OperandVar292 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable279 != null)
						{
							UnityEngine.GameObject prop291 = StoredVariable279.Enemy; //IsContext = False IsNew = False
							if(prop291 != null)
							{
								OperandVar292 = prop291;
							}
						}
						System.Boolean prop293 = External.Contains( (OperandVar290), (OperandVar292)); //IsContext = False IsNew = False
						OperandVar294 = prop293;
						
						System.Boolean OperandVar296 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable278 != null)
						{
							System.Boolean prop295 = StoredVariable278.IsActive; //IsContext = False IsNew = False
							OperandVar296 = prop295;
						}
						if(ifResult281 = ( ( (OperandVar288))) && ( (!(OperandVar294))) && ( ( (OperandVar296))))
						{
							applicable = true;
							OperandVar297 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar297);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.foe_role subContext298 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext298 ContextSwitchInterpreter
				if(subContext298 != null)
				{
					
					{
						Blackboards.ruler_role subContext299 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
						//ContextStatement Blackboards.ruler_role subContext299 ContextSwitchInterpreter
						if(subContext299 != null)
						{
							UnityEngine.GameObject OperandVar301 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							if(subContext298 != null)
							{
								UnityEngine.GameObject prop300 = subContext298.Enemy; //IsContext = False IsNew = False
								if(prop300 != null)
								{
									OperandVar301 = prop300;
								}
							}
							subContext299.AtWarWith.Add( (OperandVar301));
						}
					}
					
					{
						UnityEngine.GameObject subContext302 = subContext298.Enemy; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext302 ContextPropertySwitchInterpreter
						if(subContext302 != null)
						{
							
							{
								Blackboards.ruler_role subContext303 = (Blackboards.ruler_role)subContext302.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext303 ContextSwitchInterpreter
								if(subContext303 != null)
								{
									UnityEngine.GameObject OperandVar304 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar304 = root;
									subContext303.AtWarWith.Add( (OperandVar304));
								}
							}
						}
					}
				}
			}
			UnityEngine.GameObject event_war_declaration = new UnityEngine.GameObject("event_war_declaration"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject event_war_declaration305 = event_war_declaration; //IsContext = True IsNew = False
				Event AddContext306 = (Event)event_war_declaration.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext306 ContextSwitchInterpreter
					if(AddContext306 != null)
					{
						UnityEngine.GameObject OperandVar307 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar307 = root;
						AddContext306.Context = (UnityEngine.GameObject)( (OperandVar307));
					}
				}
				Blackboards.war_declaration AddContext308 = (Blackboards.war_declaration)event_war_declaration.AddComponent(typeof(Blackboards.war_declaration)); //IsContext = True IsNew = True
				Blackboards.targeted_event AddContext309 = (Blackboards.targeted_event)event_war_declaration.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext309 ContextSwitchInterpreter
					if(AddContext309 != null)
					{
						UnityEngine.GameObject OperandVar312 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.foe_role StoredVariable310 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
						if(StoredVariable310 != null)
						{
							UnityEngine.GameObject prop311 = StoredVariable310.Enemy; //IsContext = False IsNew = False
							if(prop311 != null)
							{
								OperandVar312 = prop311;
							}
						}
						AddContext309.Target = (UnityEngine.GameObject)( (OperandVar312));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(event_war_declaration, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class gather_reinforcements : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar319 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable313 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable313 != null)
			{
				Blackboards.foe_role StoredVariable314 = ((Blackboards.foe_role)StoredVariable313.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
				if(StoredVariable314 != null)
				{
					Blackboards.ruler_role StoredVariable315 = ((Blackboards.ruler_role)StoredVariable314.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable315 != null)
					{
						System.Boolean ifResult316; //IsContext = False IsNew = False
						System.Boolean OperandVar318 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable313 != null)
						{
							System.Boolean prop317 = StoredVariable313.IsActive; //IsContext = False IsNew = False
							OperandVar318 = prop317;
						}
						if(ifResult316 =  (OperandVar318))
						{
							applicable = true;
							OperandVar319 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar319);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar322 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable320 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable320 != null)
			{
				System.Single prop321 = StoredVariable320.People; //IsContext = False IsNew = False
				OperandVar322 = prop321;
			}
			
			
			return (System.Single)( ( (OperandVar322))) - ( ( (0.3f)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject gather_reinforcements = new UnityEngine.GameObject("gather_reinforcements"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject gather_reinforcements323 = gather_reinforcements; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext324 = (Blackboards.notify_event)gather_reinforcements.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext324 ContextSwitchInterpreter
					if(AddContext324 != null)
					{
						UnityEngine.GameObject OperandVar325 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar325 = root;
						AddContext324.Who = (UnityEngine.GameObject)( (OperandVar325));
						
						AddContext324.Data = (System.String)( ("gather_reinforcements"));
					}
				}
			}
			
			{
				Blackboards.ruler_role subContext326 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext326 ContextSwitchInterpreter
				if(subContext326 != null)
				{
					
					System.Single OperandVar328 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop327 = subContext326.Forces; //IsContext = False IsNew = False
					OperandVar328 = prop327;
					
					
					subContext326.Forces = (System.Single)(( ( (OperandVar328))) + ( ( (7f))));
					
					System.Single OperandVar330 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop329 = subContext326.People; //IsContext = False IsNew = False
					OperandVar330 = prop329;
					
					
					subContext326.People = (System.Single)(( ( (OperandVar330))) - ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true)]
    public class growth : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar338 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable331 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable331 != null)
			{
				Blackboards.ruler_role StoredVariable332 = ((Blackboards.ruler_role)StoredVariable331.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable332 != null)
				{
					System.Boolean ifResult333; //IsContext = False IsNew = False
					
					
					System.Single OperandVar335 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop334 = StoredVariable332.People; //IsContext = False IsNew = False
					OperandVar335 = prop334;
					
					
					
					System.Boolean OperandVar337 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable331 != null)
					{
						System.Boolean prop336 = StoredVariable331.IsActive; //IsContext = False IsNew = False
						OperandVar337 = prop336;
					}
					if(ifResult333 = ( (( ( (OperandVar335))) < ( ( (1f))))) && ( (!(OperandVar337))))
					{
						applicable = true;
						OperandVar338 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar338);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.ruler_role subContext339 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext339 ContextSwitchInterpreter
				if(subContext339 != null)
				{
					System.Single OperandVar341 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop340 = subContext339.People; //IsContext = False IsNew = False
					OperandVar341 = prop340;
					
					subContext339.People = (System.Single)(( (OperandVar341)) * ( (1.2f)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class order_a_wunderwaffe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar354 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable342 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable342 != null)
			{
				Blackboards.ruler_role StoredVariable343 = ((Blackboards.ruler_role)StoredVariable342.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable343 != null)
				{
					Blackboards.foe_role StoredVariable344 = ((Blackboards.foe_role)StoredVariable343.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable344 != null)
					{
						System.Boolean ifResult345; //IsContext = False IsNew = False
						
						System.Boolean OperandVar347 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable342 != null)
						{
							System.Boolean prop346 = StoredVariable342.IsActive; //IsContext = False IsNew = False
							OperandVar347 = prop346;
						}
						
						System.Boolean OperandVar353 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar349 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable343 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop348 = StoredVariable343.AtWarWith; //IsContext = False IsNew = False
							if(prop348 != null)
							{
								OperandVar349 = prop348;
							}
						}
						UnityEngine.GameObject OperandVar351 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop350 = StoredVariable344.Enemy; //IsContext = False IsNew = False
						if(prop350 != null)
						{
							OperandVar351 = prop350;
						}
						System.Boolean prop352 = External.Contains( (OperandVar349), (OperandVar351)); //IsContext = False IsNew = False
						OperandVar353 = prop352;
						if(ifResult345 = ( ( (OperandVar347))) && ( ( (OperandVar353))))
						{
							applicable = true;
							OperandVar354 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar354);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar357 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable355 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable355 != null)
			{
				System.Single prop356 = StoredVariable355.ThreatLevel; //IsContext = False IsNew = False
				OperandVar357 = prop356;
			}
			
			return (System.Single)( (OperandVar357)) * ( (0.3f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject wunder_waffe = new UnityEngine.GameObject("wunder_waffe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wunder_waffe358 = wunder_waffe; //IsContext = True IsNew = False
				Actor AddContext359 = (Actor)wunder_waffe.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.buildable AddContext360 = (Blackboards.buildable)wunder_waffe.AddComponent(typeof(Blackboards.buildable)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.buildable AddContext360 ContextSwitchInterpreter
					if(AddContext360 != null)
					{
						
						AddContext360.Cost = (System.Single)( (20f));
					}
				}
				Blackboards.old_weapon AddContext361 = (Blackboards.old_weapon)wunder_waffe.AddComponent(typeof(Blackboards.old_weapon)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wunder_waffe, 0.1f);
			
			{
				Blackboards.ruler_role subContext362 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext362 ContextSwitchInterpreter
				if(subContext362 != null)
				{
					UnityEngine.GameObject OperandVar363 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar363 = wunder_waffe;
					subContext362.Wunderwaffe = (UnityEngine.GameObject)( (OperandVar363));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class genius_found : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar373 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable364 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable364 != null)
			{
				Blackboards.ruler_role StoredVariable365 = ((Blackboards.ruler_role)StoredVariable364.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable365 != null)
				{
					System.Boolean ifResult366; //IsContext = False IsNew = False
					
					System.Boolean OperandVar370 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop367 = StoredVariable365.Wunderwaffe; //IsContext = False IsNew = False
					if(prop367 != null)
					{
						Blackboards.old_weapon StoredVariable368 = ((Blackboards.old_weapon)prop367.GetComponent(typeof(Blackboards.old_weapon))); //IsContext = False IsNew = False
						if(StoredVariable368 != null)
						{
							Blackboards.buildable StoredVariable369 = ((Blackboards.buildable)StoredVariable368.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
							if(StoredVariable369 != null)
							{
								applicable = true;
								OperandVar370 = applicable;
							}
						}
					}
					
					System.Boolean OperandVar372 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable364 != null)
					{
						System.Boolean prop371 = StoredVariable364.IsActive; //IsContext = False IsNew = False
						OperandVar372 = prop371;
					}
					if(ifResult366 = ( ( (OperandVar370))) && ( (!(OperandVar372))))
					{
						applicable = true;
						OperandVar373 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar373);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject genius = new UnityEngine.GameObject("genius"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject genius374 = genius; //IsContext = True IsNew = False
				Markers AddContext375 = (Markers)genius.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Actor AddContext376 = (Actor)genius.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.worker AddContext377 = (Blackboards.worker)genius.AddComponent(typeof(Blackboards.worker)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.worker AddContext377 ContextSwitchInterpreter
					if(AddContext377 != null)
					{
						UnityEngine.GameObject OperandVar378 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar378 = root;
						AddContext377.WorksFor = (UnityEngine.GameObject)( (OperandVar378));
					}
				}
				Blackboards.builder AddContext379 = (Blackboards.builder)genius.AddComponent(typeof(Blackboards.builder)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(genius, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class commence_battle : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar395 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable380 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable380 != null)
			{
				Blackboards.ruler_role StoredVariable381 = ((Blackboards.ruler_role)StoredVariable380.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable381 != null)
				{
					Blackboards.foe_role StoredVariable382 = ((Blackboards.foe_role)StoredVariable381.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable382 != null)
					{
						System.Boolean ifResult383; //IsContext = False IsNew = False
						
						System.Boolean OperandVar385 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable380 != null)
						{
							System.Boolean prop384 = StoredVariable380.IsActive; //IsContext = False IsNew = False
							OperandVar385 = prop384;
						}
						
						System.Boolean OperandVar391 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar387 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable381 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop386 = StoredVariable381.AtWarWith; //IsContext = False IsNew = False
							if(prop386 != null)
							{
								OperandVar387 = prop386;
							}
						}
						UnityEngine.GameObject OperandVar389 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop388 = StoredVariable382.Enemy; //IsContext = False IsNew = False
						if(prop388 != null)
						{
							OperandVar389 = prop388;
						}
						System.Boolean prop390 = External.Contains( (OperandVar387), (OperandVar389)); //IsContext = False IsNew = False
						OperandVar391 = prop390;
						
						System.Boolean OperandVar394 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop392 = StoredVariable382.Enemy; //IsContext = False IsNew = False
						if(prop392 != null)
						{
							Blackboards.ruler_role StoredVariable393 = ((Blackboards.ruler_role)prop392.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable393 != null)
							{
								applicable = true;
								OperandVar394 = applicable;
							}
						}
						if(ifResult383 = ( ( (OperandVar385))) && ( ( (OperandVar391))) && ( ( (OperandVar394))))
						{
							applicable = true;
							OperandVar395 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar395);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar398 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable396 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable396 != null)
			{
				System.Single prop397 = StoredVariable396.ThreatLevel; //IsContext = False IsNew = False
				OperandVar398 = prop397;
			}
			return (System.Single)( (1f)) / ( (OperandVar398));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject battle_event = new UnityEngine.GameObject("battle_event"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject battle_event399 = battle_event; //IsContext = True IsNew = False
				Event AddContext400 = (Event)battle_event.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext400 ContextSwitchInterpreter
					if(AddContext400 != null)
					{
						UnityEngine.GameObject OperandVar401 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar401 = root;
						AddContext400.Context = (UnityEngine.GameObject)( (OperandVar401));
					}
				}
				Blackboards.targeted_event AddContext402 = (Blackboards.targeted_event)battle_event.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext402 ContextSwitchInterpreter
					if(AddContext402 != null)
					{
						UnityEngine.GameObject OperandVar405 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.foe_role StoredVariable403 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
						if(StoredVariable403 != null)
						{
							UnityEngine.GameObject prop404 = StoredVariable403.Enemy; //IsContext = False IsNew = False
							if(prop404 != null)
							{
								OperandVar405 = prop404;
							}
						}
						AddContext402.Target = (UnityEngine.GameObject)( (OperandVar405));
					}
				}
				Blackboards.battle_event AddContext406 = (Blackboards.battle_event)battle_event.AddComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(battle_event, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class battle_calculation : EventAction {
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar419 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable407 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable407 != null)
			{
				Blackboards.battle_event StoredVariable408 = ((Blackboards.battle_event)StoredVariable407.GetComponent(typeof(Blackboards.battle_event))); //IsContext = False IsNew = False
				if(StoredVariable408 != null)
				{
					Blackboards.targeted_event StoredVariable409 = ((Blackboards.targeted_event)StoredVariable408.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
					if(StoredVariable409 != null)
					{
						System.Boolean ifResult410; //IsContext = False IsNew = False
						
						System.Boolean OperandVar414 = default(System.Boolean); //IsContext = False IsNew = False
						Event StoredVariable411 = ((Event)StoredVariable409.GetComponent(typeof(Event))); //IsContext = False IsNew = False
						if(StoredVariable411 != null)
						{
							UnityEngine.GameObject prop412 = StoredVariable411.Context; //IsContext = False IsNew = False
							if(prop412 != null)
							{
								Blackboards.ruler_role StoredVariable413 = ((Blackboards.ruler_role)prop412.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable413 != null)
								{
									applicable = true;
									OperandVar414 = applicable;
								}
							}
						}
						
						System.Boolean OperandVar418 = default(System.Boolean); //IsContext = False IsNew = False
						Blackboards.targeted_event StoredVariable415 = ((Blackboards.targeted_event)StoredVariable409.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
						if(StoredVariable415 != null)
						{
							UnityEngine.GameObject prop416 = StoredVariable415.Target; //IsContext = False IsNew = False
							if(prop416 != null)
							{
								Blackboards.ruler_role StoredVariable417 = ((Blackboards.ruler_role)prop416.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
								if(StoredVariable417 != null)
								{
									applicable = true;
									OperandVar418 = applicable;
								}
							}
						}
						if(ifResult410 = ( ( (OperandVar414))) && ( ( (OperandVar418))))
						{
							applicable = true;
							OperandVar419 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar419);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			System.Single OperandVar421 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop420 = External.Intensity(); //IsContext = False IsNew = False
			OperandVar421 = prop420;
			
			System.Single intensity_multiplier = ( ( (1f))) + ( (( (OperandVar421)) * ( (4f)))); //IsContext = False IsNew = False
			Blackboards.ruler_role OperandVar425 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
			Event StoredVariable422 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable422 != null)
			{
				UnityEngine.GameObject prop423 = StoredVariable422.Context; //IsContext = False IsNew = False
				if(prop423 != null)
				{
					Blackboards.ruler_role StoredVariable424 = ((Blackboards.ruler_role)prop423.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable424 != null)
					{
						OperandVar425 = StoredVariable424;
					}
				}
			}
			Blackboards.ruler_role first =  (OperandVar425); //IsContext = False IsNew = False
			Blackboards.ruler_role OperandVar429 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
			Blackboards.targeted_event StoredVariable426 = ((Blackboards.targeted_event)root.GetComponent(typeof(Blackboards.targeted_event))); //IsContext = False IsNew = False
			if(StoredVariable426 != null)
			{
				UnityEngine.GameObject prop427 = StoredVariable426.Target; //IsContext = False IsNew = False
				if(prop427 != null)
				{
					Blackboards.ruler_role StoredVariable428 = ((Blackboards.ruler_role)prop427.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable428 != null)
					{
						OperandVar429 = StoredVariable428;
					}
				}
			}
			Blackboards.ruler_role second =  (OperandVar429); //IsContext = False IsNew = False
			System.Single OperandVar431 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop430 = first.Forces; //IsContext = False IsNew = False
			OperandVar431 = prop430;
			System.Single pre_battle_first =  (OperandVar431); //IsContext = False IsNew = False
			System.Single OperandVar433 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop432 = second.Forces; //IsContext = False IsNew = False
			OperandVar433 = prop432;
			System.Single pre_battle_second =  (OperandVar433); //IsContext = False IsNew = False
			
			System.Single OperandVar435 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop434 = first.Forces; //IsContext = False IsNew = False
			OperandVar435 = prop434;
			
			System.Single OperandVar437 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop436 = second.Forces; //IsContext = False IsNew = False
			OperandVar437 = prop436;
			if(( ( (OperandVar435))) > ( ( (OperandVar437))))
			{
				
				{
					//ContextStatement Blackboards.ruler_role second ContextSwitchInterpreter
					if(second != null)
					{
						System.Single OperandVar439 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop438 = second.Forces; //IsContext = False IsNew = False
						OperandVar439 = prop438;
						
						System.Single OperandVar440 = default(System.Single); //IsContext = False IsNew = False
						OperandVar440 = intensity_multiplier;
						second.Forces = (System.Single)(( (OperandVar439)) / ( (2f)) / ( (OperandVar440)));
					}
				}
				
				{
					//ContextStatement Blackboards.ruler_role first ContextSwitchInterpreter
					if(first != null)
					{
						System.Single OperandVar442 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop441 = first.Forces; //IsContext = False IsNew = False
						OperandVar442 = prop441;
						System.Single OperandVar443 = default(System.Single); //IsContext = False IsNew = False
						OperandVar443 = intensity_multiplier;
						first.Forces = (System.Single)(( (OperandVar442)) / ( (OperandVar443)));
					}
				}
				
				{
					Blackboards.battle_event subContext444 = (Blackboards.battle_event)root.GetComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.battle_event subContext444 ContextSwitchInterpreter
					if(subContext444 != null)
					{
						UnityEngine.GameObject OperandVar447 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar445 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar445 = first;
						UnityEngine.GameObject prop446 = External.Gameobject( (OperandVar445)); //IsContext = False IsNew = False
						if(prop446 != null)
						{
							OperandVar447 = prop446;
						}
						subContext444.Won = (UnityEngine.GameObject)( (OperandVar447));
						UnityEngine.GameObject OperandVar450 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar448 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar448 = second;
						UnityEngine.GameObject prop449 = External.Gameobject( (OperandVar448)); //IsContext = False IsNew = False
						if(prop449 != null)
						{
							OperandVar450 = prop449;
						}
						subContext444.Lost = (UnityEngine.GameObject)( (OperandVar450));
						
						System.Single OperandVar451 = default(System.Single); //IsContext = False IsNew = False
						OperandVar451 = pre_battle_first;
						
						System.Single OperandVar453 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop452 = first.Forces; //IsContext = False IsNew = False
						OperandVar453 = prop452;
						subContext444.WinnerForcesLost = (System.Single)(( ( (OperandVar451))) - ( ( (OperandVar453))));
						
						System.Single OperandVar454 = default(System.Single); //IsContext = False IsNew = False
						OperandVar454 = pre_battle_second;
						
						System.Single OperandVar456 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop455 = second.Forces; //IsContext = False IsNew = False
						OperandVar456 = prop455;
						subContext444.LooserForcesLost = (System.Single)(( ( (OperandVar454))) - ( ( (OperandVar456))));
					}
				}
			}
			
			System.Single OperandVar458 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop457 = first.Forces; //IsContext = False IsNew = False
			OperandVar458 = prop457;
			
			System.Single OperandVar460 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop459 = second.Forces; //IsContext = False IsNew = False
			OperandVar460 = prop459;
			if(( ( (OperandVar458))) < ( ( (OperandVar460))))
			{
				
				{
					//ContextStatement Blackboards.ruler_role first ContextSwitchInterpreter
					if(first != null)
					{
						System.Single OperandVar462 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop461 = first.Forces; //IsContext = False IsNew = False
						OperandVar462 = prop461;
						
						System.Single OperandVar463 = default(System.Single); //IsContext = False IsNew = False
						OperandVar463 = intensity_multiplier;
						first.Forces = (System.Single)(( (OperandVar462)) / ( (2f)) / ( (OperandVar463)));
					}
				}
				
				{
					//ContextStatement Blackboards.ruler_role second ContextSwitchInterpreter
					if(second != null)
					{
						System.Single OperandVar465 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop464 = second.Forces; //IsContext = False IsNew = False
						OperandVar465 = prop464;
						System.Single OperandVar466 = default(System.Single); //IsContext = False IsNew = False
						OperandVar466 = intensity_multiplier;
						second.Forces = (System.Single)(( (OperandVar465)) / ( (OperandVar466)));
					}
				}
				
				{
					Blackboards.battle_event subContext467 = (Blackboards.battle_event)root.GetComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.battle_event subContext467 ContextSwitchInterpreter
					if(subContext467 != null)
					{
						UnityEngine.GameObject OperandVar470 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar468 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar468 = second;
						UnityEngine.GameObject prop469 = External.Gameobject( (OperandVar468)); //IsContext = False IsNew = False
						if(prop469 != null)
						{
							OperandVar470 = prop469;
						}
						subContext467.Won = (UnityEngine.GameObject)( (OperandVar470));
						UnityEngine.GameObject OperandVar473 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.ruler_role OperandVar471 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
						OperandVar471 = first;
						UnityEngine.GameObject prop472 = External.Gameobject( (OperandVar471)); //IsContext = False IsNew = False
						if(prop472 != null)
						{
							OperandVar473 = prop472;
						}
						subContext467.Lost = (UnityEngine.GameObject)( (OperandVar473));
						
						System.Single OperandVar474 = default(System.Single); //IsContext = False IsNew = False
						OperandVar474 = pre_battle_first;
						
						System.Single OperandVar476 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop475 = first.Forces; //IsContext = False IsNew = False
						OperandVar476 = prop475;
						subContext467.LooserForcesLost = (System.Single)(( ( (OperandVar474))) - ( ( (OperandVar476))));
						
						System.Single OperandVar477 = default(System.Single); //IsContext = False IsNew = False
						OperandVar477 = pre_battle_second;
						
						System.Single OperandVar479 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop478 = second.Forces; //IsContext = False IsNew = False
						OperandVar479 = prop478;
						subContext467.WinnerForcesLost = (System.Single)(( ( (OperandVar477))) - ( ( (OperandVar479))));
					}
				}
			}
			
			System.Single OperandVar481 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop480 = first.Forces; //IsContext = False IsNew = False
			OperandVar481 = prop480;
			
			System.Single OperandVar483 = default(System.Single); //IsContext = False IsNew = False
			System.Single prop482 = second.Forces; //IsContext = False IsNew = False
			OperandVar483 = prop482;
			if(( ( (OperandVar481))) == ( ( (OperandVar483))))
			{
				
				{
					Blackboards.battle_event subContext484 = (Blackboards.battle_event)root.GetComponent(typeof(Blackboards.battle_event)); //IsContext = True IsNew = False
					//ContextStatement Blackboards.battle_event subContext484 ContextSwitchInterpreter
					if(subContext484 != null)
					{
						
						subContext484.Tie = (System.Boolean)( (true));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class build_wunderwaffe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar500 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable485 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable485 != null)
			{
				Blackboards.builder StoredVariable486 = ((Blackboards.builder)StoredVariable485.GetComponent(typeof(Blackboards.builder))); //IsContext = False IsNew = False
				if(StoredVariable486 != null)
				{
					Blackboards.worker StoredVariable487 = ((Blackboards.worker)StoredVariable486.GetComponent(typeof(Blackboards.worker))); //IsContext = False IsNew = False
					if(StoredVariable487 != null)
					{
						System.Boolean ifResult488; //IsContext = False IsNew = False
						
						System.Boolean OperandVar490 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable485 != null)
						{
							System.Boolean prop489 = StoredVariable485.IsActive; //IsContext = False IsNew = False
							OperandVar490 = prop489;
						}
						
						System.Boolean OperandVar499 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop491 = StoredVariable487.WorksFor; //IsContext = False IsNew = False
						if(prop491 != null)
						{
							Blackboards.ruler_role StoredVariable492 = ((Blackboards.ruler_role)prop491.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable492 != null)
							{
								System.Boolean ifResult493; //IsContext = False IsNew = False
								
								Blackboards.ruler_role OperandVar494 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
								OperandVar494 = StoredVariable492;
								
								System.Boolean OperandVar498 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject prop495 = StoredVariable492.Wunderwaffe; //IsContext = False IsNew = False
								if(prop495 != null)
								{
									Blackboards.buildable StoredVariable496 = ((Blackboards.buildable)prop495.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
									if(StoredVariable496 != null)
									{
										System.Boolean prop497 = StoredVariable496.Finished; //IsContext = False IsNew = False
										OperandVar498 = prop497;
									}
								}
								if(ifResult493 = ( ( (OperandVar494))) && ( (!(OperandVar498))))
								{
									OperandVar499 = ifResult493;
								}
							}
						}
						if(ifResult488 = ( ( (OperandVar490))) && ( ( (OperandVar499))))
						{
							applicable = true;
							OperandVar500 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar500);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject build_wunderwaffe = new UnityEngine.GameObject("build_wunderwaffe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject build_wunderwaffe501 = build_wunderwaffe; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext502 = (Blackboards.notify_event)build_wunderwaffe.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext502 ContextSwitchInterpreter
					if(AddContext502 != null)
					{
						UnityEngine.GameObject OperandVar503 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar503 = root;
						AddContext502.Who = (UnityEngine.GameObject)( (OperandVar503));
						
						AddContext502.Data = (System.String)( ("build_wunderwaffe"));
					}
				}
			}
			
			{
				Blackboards.worker subContext504 = (Blackboards.worker)root.GetComponent(typeof(Blackboards.worker)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.worker subContext504 ContextSwitchInterpreter
				if(subContext504 != null)
				{
					
					{
						UnityEngine.GameObject subContext505 = subContext504.WorksFor; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext505 ContextPropertySwitchInterpreter
						if(subContext505 != null)
						{
							
							{
								Blackboards.ruler_role subContext506 = (Blackboards.ruler_role)subContext505.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext506 ContextSwitchInterpreter
								if(subContext506 != null)
								{
									
									{
										UnityEngine.GameObject subContext507 = subContext506.Wunderwaffe; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext507 ContextPropertySwitchInterpreter
										if(subContext507 != null)
										{
											
											{
												Blackboards.buildable subContext508 = (Blackboards.buildable)subContext507.GetComponent(typeof(Blackboards.buildable)); //IsContext = True IsNew = False
												//ContextStatement Blackboards.buildable subContext508 ContextSwitchInterpreter
												if(subContext508 != null)
												{
													
													System.Single OperandVar510 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop509 = subContext508.CurrentInvestment; //IsContext = False IsNew = False
													OperandVar510 = prop509;
													
													
													subContext508.CurrentInvestment = (System.Single)(( ( (OperandVar510))) + ( ( (5f))));
													
													System.Single OperandVar512 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop511 = subContext508.CurrentInvestment; //IsContext = False IsNew = False
													OperandVar512 = prop511;
													
													System.Single OperandVar514 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop513 = subContext508.Cost; //IsContext = False IsNew = False
													OperandVar514 = prop513;
													if(( ( (OperandVar512))) >= ( ( (OperandVar514))))
													{
														
														subContext508.Finished = (System.Boolean)( (true));
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class test_wunderwaffe : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar538 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable515 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable515 != null)
			{
				Blackboards.ruler_role StoredVariable516 = ((Blackboards.ruler_role)StoredVariable515.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable516 != null)
				{
					Blackboards.foe_role StoredVariable517 = ((Blackboards.foe_role)StoredVariable516.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable517 != null)
					{
						System.Boolean ifResult518; //IsContext = False IsNew = False
						
						System.Boolean OperandVar520 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable515 != null)
						{
							System.Boolean prop519 = StoredVariable515.IsActive; //IsContext = False IsNew = False
							OperandVar520 = prop519;
						}
						
						System.Boolean OperandVar526 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar522 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable516 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop521 = StoredVariable516.AtWarWith; //IsContext = False IsNew = False
							if(prop521 != null)
							{
								OperandVar522 = prop521;
							}
						}
						UnityEngine.GameObject OperandVar524 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop523 = StoredVariable517.Enemy; //IsContext = False IsNew = False
						if(prop523 != null)
						{
							OperandVar524 = prop523;
						}
						System.Boolean prop525 = External.Contains( (OperandVar522), (OperandVar524)); //IsContext = False IsNew = False
						OperandVar526 = prop525;
						
						System.Boolean OperandVar529 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop527 = StoredVariable517.Enemy; //IsContext = False IsNew = False
						if(prop527 != null)
						{
							Blackboards.ruler_role StoredVariable528 = ((Blackboards.ruler_role)prop527.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable528 != null)
							{
								applicable = true;
								OperandVar529 = applicable;
							}
						}
						
						System.Boolean OperandVar533 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar531 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable516 != null)
						{
							UnityEngine.GameObject prop530 = StoredVariable516.Wunderwaffe; //IsContext = False IsNew = False
							if(prop530 != null)
							{
								OperandVar531 = prop530;
							}
						}
						System.Boolean prop532 = External.Has( (OperandVar531)); //IsContext = False IsNew = False
						OperandVar533 = prop532;
						
						System.Boolean OperandVar537 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable516 != null)
						{
							UnityEngine.GameObject prop534 = StoredVariable516.Wunderwaffe; //IsContext = False IsNew = False
							if(prop534 != null)
							{
								Blackboards.buildable StoredVariable535 = ((Blackboards.buildable)prop534.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
								if(StoredVariable535 != null)
								{
									System.Boolean prop536 = StoredVariable535.Finished; //IsContext = False IsNew = False
									OperandVar537 = prop536;
								}
							}
						}
						if(ifResult518 = ( ( (OperandVar520))) && ( ( (OperandVar526))) && ( ( (OperandVar529))) && ( ( (OperandVar533))) && ( ( (OperandVar537))))
						{
							applicable = true;
							OperandVar538 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar538);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar541 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable539 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable539 != null)
			{
				System.Single prop540 = StoredVariable539.ThreatLevel; //IsContext = False IsNew = False
				OperandVar541 = prop540;
			}
			
			return (System.Single)( (OperandVar541)) * ( (0.5f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject test_wunderwaffe = new UnityEngine.GameObject("test_wunderwaffe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject test_wunderwaffe542 = test_wunderwaffe; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext543 = (Blackboards.notify_event)test_wunderwaffe.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext543 ContextSwitchInterpreter
					if(AddContext543 != null)
					{
						UnityEngine.GameObject OperandVar544 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar544 = root;
						AddContext543.Who = (UnityEngine.GameObject)( (OperandVar544));
						
						AddContext543.Data = (System.String)( ("test_wunderwaffe"));
					}
				}
			}
			
			{
				Blackboards.foe_role subContext545 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext545 ContextSwitchInterpreter
				if(subContext545 != null)
				{
					
					{
						UnityEngine.GameObject subContext546 = subContext545.Enemy; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext546 ContextPropertySwitchInterpreter
						if(subContext546 != null)
						{
							
							{
								Blackboards.ruler_role subContext547 = (Blackboards.ruler_role)subContext546.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext547 ContextSwitchInterpreter
								if(subContext547 != null)
								{
									
									System.Single OperandVar549 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop548 = subContext547.Forces; //IsContext = False IsNew = False
									OperandVar549 = prop548;
									
									
									subContext547.Forces = (System.Single)(( ( (OperandVar549))) - ( ( (10f))));
									
									subContext547.People = (System.Single)( (0f));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar554 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable550 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable550 != null)
			{
				System.Boolean ifResult551; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar553 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop552 = StoredVariable550.Places; //IsContext = False IsNew = False
				if(prop552 != null)
				{
					OperandVar553 = prop552;
				}
				
				
				if(ifResult551 = ( ( (OperandVar553 != null ? OperandVar553.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar554 = applicable;
				}
			}
			return (System.Boolean) (OperandVar554);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext555 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext555 ContextSwitchInterpreter
				if(subContext555 != null)
				{
					
					subContext555.Size = (System.Int32)( (5f));
					System.Single OperandVar557 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop556 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar557 = prop556;
					for (int i = 0; i <  (OperandVar557); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc558 = loc; //IsContext = True IsNew = False
							Entity AddContext559 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext559 ContextSwitchInterpreter
								if(AddContext559 != null)
								{
									UnityEngine.Vector3 OperandVar569 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar563 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar561 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop560 = External.MapX(); //IsContext = False IsNew = False
									OperandVar561 = prop560;
									System.Single prop562 = External.Random( (0f), (OperandVar561)); //IsContext = False IsNew = False
									OperandVar563 = prop562;
									System.Single OperandVar567 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar565 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop564 = External.MapX(); //IsContext = False IsNew = False
									OperandVar565 = prop564;
									System.Single prop566 = External.Random( (0f), (OperandVar565)); //IsContext = False IsNew = False
									OperandVar567 = prop566;
									UnityEngine.Vector3 prop568 = External.Vec( (OperandVar563), (OperandVar567)); //IsContext = False IsNew = False
									OperandVar569 = prop568;
									AddContext559.Position = (UnityEngine.Vector3)( (OperandVar569));
								}
							}
							Place AddContext570 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext570 ContextSwitchInterpreter
								if(AddContext570 != null)
								{
									System.Single OperandVar572 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop571 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar572 = prop571;
									AddContext570.Size = (System.Int32)( (OperandVar572));
								}
							}
							Markers AddContext573 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext573 ContextSwitchInterpreter
								if(AddContext573 != null)
								{
									System.String OperandVar574 = default(System.String); //IsContext = False IsNew = False
									OperandVar574 = "history_place";
									AddContext573.SetMarker(( (OperandVar574)).ToString());
								}
							}
							Named AddContext575 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext575 ContextSwitchInterpreter
								if(AddContext575 != null)
								{
									
									
									
									AddContext575.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar578 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar576 = default(System.String); //IsContext = False IsNew = False
									OperandVar576 = "human_name";
									System.String prop577 = External.RandomName( (OperandVar576)); //IsContext = False IsNew = False
									if(prop577 != null)
									{
										OperandVar578 = prop577;
									}
									AddContext575.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar578)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc, 0.1f);
						Place OperandVar580 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable579 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable579 != null)
						{
							OperandVar580 = StoredVariable579;
						}
						subContext555.Attach((Place)( (OperandVar580)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar594 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable581 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable581 != null)
			{
				Markers StoredVariable582 = ((Markers)StoredVariable581.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable582 != null)
				{
					System.Boolean ifResult583; //IsContext = False IsNew = False
					
					System.Boolean OperandVar590 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable581 != null)
					{
						UnityEngine.GameObject prop584 = StoredVariable581.ShowedObject; //IsContext = False IsNew = False
						if(prop584 != null)
						{
							System.Boolean ifResult585; //IsContext = False IsNew = False
							System.Boolean OperandVar589 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar587 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable586 = ((Named)prop584.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable586 != null)
							{
								OperandVar587 = StoredVariable586;
							}
							System.Boolean prop588 = External.Has( (OperandVar587)); //IsContext = False IsNew = False
							OperandVar589 = prop588;
							if(ifResult585 =  (OperandVar589))
							{
								OperandVar590 = ifResult585;
							}
						}
					}
					
					System.Boolean OperandVar593 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar591 = default(System.String); //IsContext = False IsNew = False
					OperandVar591 = "named_ui_marker";
					System.Boolean prop592 = StoredVariable582.HasMarker( (OperandVar591)); //IsContext = False IsNew = False
					OperandVar593 = prop592;
					if(ifResult583 = ( ( (OperandVar590))) && ( (!(OperandVar593))))
					{
						applicable = true;
						OperandVar594 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar594);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext595 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext595 ContextSwitchInterpreter
				if(subContext595 != null)
				{
					System.String OperandVar596 = default(System.String); //IsContext = False IsNew = False
					OperandVar596 = "named_ui_marker";
					subContext595.SetUiMarker(( (OperandVar596)).ToString());
				}
			}
			
			{
				UiObject subContext597 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext597 ContextSwitchInterpreter
				if(subContext597 != null)
				{
					Named OperandVar600 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop598 = subContext597.ShowedObject; //IsContext = False IsNew = False
					if(prop598 != null)
					{
						Named StoredVariable599 = ((Named)prop598.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable599 != null)
						{
							OperandVar600 = StoredVariable599;
						}
					}
					Named showed_named =  (OperandVar600); //IsContext = False IsNew = False
					TextField ContextVar601 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar601 ContextSwitchInterpreter
						if(ContextVar601 != null)
						{
							System.String OperandVar603 = default(System.String); //IsContext = False IsNew = False
							System.String prop602 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop602 != null)
							{
								OperandVar603 = prop602;
							}
							ContextVar601.Show(( (OperandVar603)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda604 = () => 
									{
										System.String OperandVar606 = default(System.String); //IsContext = False IsNew = False
										System.String prop605 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop605 != null)
										{
											OperandVar606 = prop605;
										}
										ContextVar601.Show(( (OperandVar606)).ToString());
									};
									showed_named.OnUpdate(Lambda604);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext607 = ContextVar601.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext607 ContextPropertySwitchInterpreter
								if(subContext607 != null)
								{
									
									subContext607.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar608 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar608 != null) EntVar608.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar617 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable609 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable609 != null)
			{
				Place StoredVariable610 = ((Place)StoredVariable609.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable610 != null)
				{
					System.Boolean ifResult611; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar613 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop612 = StoredVariable610.Agents; //IsContext = False IsNew = False
					if(prop612 != null)
					{
						OperandVar613 = prop612;
					}
					
					
					
					System.Boolean OperandVar616 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar614 = default(System.String); //IsContext = False IsNew = False
					OperandVar614 = "agents_pool";
					System.Boolean prop615 = StoredVariable609.HasMarker( (OperandVar614)); //IsContext = False IsNew = False
					OperandVar616 = prop615;
					if(ifResult611 = ( (( ( (OperandVar613 != null ? OperandVar613.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar616))))
					{
						applicable = true;
						OperandVar617 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar617);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext618 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext618 ContextSwitchInterpreter
				if(subContext618 != null)
				{
					
					subContext618.Size = (System.Int32)( (5f));
					System.Single OperandVar620 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop619 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar620 = prop619;
					for (int i = 0; i <  (OperandVar620); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag621 = ag; //IsContext = True IsNew = False
							Entity AddContext622 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext623 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext624 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext624 ContextSwitchInterpreter
								if(AddContext624 != null)
								{
									System.Single OperandVar626 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop625 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar626 = prop625;
									AddContext624.Age = (System.Int32)( (OperandVar626));
								}
							}
							Named AddContext627 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext627 ContextSwitchInterpreter
								if(AddContext627 != null)
								{
									
									
									
									AddContext627.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar630 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar628 = default(System.String); //IsContext = False IsNew = False
									OperandVar628 = "human_name";
									System.String prop629 = External.RandomName( (OperandVar628)); //IsContext = False IsNew = False
									if(prop629 != null)
									{
										OperandVar630 = prop629;
									}
									AddContext627.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar630)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar632 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable631 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable631 != null)
						{
							OperandVar632 = StoredVariable631;
						}
						subContext618.Attach((Agent)( (OperandVar632)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar639 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable633 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable633 != null)
			{
				System.Boolean ifResult634; //IsContext = False IsNew = False
				System.Boolean OperandVar638 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar636 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable635 = ((Blackboards.event_marker)StoredVariable633.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable635 != null)
				{
					OperandVar636 = StoredVariable635;
				}
				System.Boolean prop637 = External.Has( (OperandVar636)); //IsContext = False IsNew = False
				OperandVar638 = prop637;
				if(ifResult634 = !(OperandVar638))
				{
					applicable = true;
					OperandVar639 = applicable;
				}
			}
			return (System.Boolean) (OperandVar639);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar640 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar640 != null) EntVar640.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar647 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable641 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable641 != null)
			{
				System.Boolean ifResult642; //IsContext = False IsNew = False
				System.Boolean OperandVar646 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar644 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable643 = ((Blackboards.personality)StoredVariable641.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable643 != null)
				{
					OperandVar644 = StoredVariable643;
				}
				System.Boolean prop645 = External.Has( (OperandVar644)); //IsContext = False IsNew = False
				OperandVar646 = prop645;
				if(ifResult642 = !(OperandVar646))
				{
					applicable = true;
					OperandVar647 = applicable;
				}
			}
			return (System.Boolean) (OperandVar647);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar648 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar648 != null) EntVar648.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar655 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable649 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable649 != null)
			{
				System.Boolean ifResult650; //IsContext = False IsNew = False
				System.Boolean OperandVar654 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar652 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable651 = ((Blackboards.aged_generation)StoredVariable649.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable651 != null)
				{
					OperandVar652 = StoredVariable651;
				}
				System.Boolean prop653 = External.Has( (OperandVar652)); //IsContext = False IsNew = False
				OperandVar654 = prop653;
				if(ifResult650 = !(OperandVar654))
				{
					applicable = true;
					OperandVar655 = applicable;
				}
			}
			return (System.Boolean) (OperandVar655);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar656 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar656 != null) EntVar656.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar666 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable657 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable657 != null)
			{
				Markers StoredVariable658 = ((Markers)StoredVariable657.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable658 != null)
				{
					System.Boolean ifResult659; //IsContext = False IsNew = False
					
					System.Boolean OperandVar662 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar660 = default(System.String); //IsContext = False IsNew = False
					OperandVar660 = "map_anchored";
					System.Boolean prop661 = StoredVariable658.HasMarker( (OperandVar660)); //IsContext = False IsNew = False
					OperandVar662 = prop661;
					
					System.Boolean OperandVar665 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar663 = default(System.String); //IsContext = False IsNew = False
					OperandVar663 = "history_place";
					System.Boolean prop664 = StoredVariable658.HasMarker( (OperandVar663)); //IsContext = False IsNew = False
					OperandVar665 = prop664;
					if(ifResult659 = ( (!(OperandVar662))) && ( ( (OperandVar665))))
					{
						applicable = true;
						OperandVar666 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar666);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext667 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext667 ContextSwitchInterpreter
				if(subContext667 != null)
				{
					System.String OperandVar668 = default(System.String); //IsContext = False IsNew = False
					OperandVar668 = "map_anchored";
					subContext667.SetUiMarker(( (OperandVar668)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar669 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar669 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar669)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar676 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable670 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable670 != null)
			{
				Markers StoredVariable671 = ((Markers)StoredVariable670.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable671 != null)
				{
					System.Boolean ifResult672; //IsContext = False IsNew = False
					System.Boolean OperandVar675 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar673 = default(System.String); //IsContext = False IsNew = False
					OperandVar673 = "encounter_ui_enlist";
					System.Boolean prop674 = StoredVariable671.HasMarker( (OperandVar673)); //IsContext = False IsNew = False
					OperandVar675 = prop674;
					if(ifResult672 = !(OperandVar675))
					{
						applicable = true;
						OperandVar676 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar676);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext677 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext677 ContextSwitchInterpreter
				if(subContext677 != null)
				{
					System.String OperandVar678 = default(System.String); //IsContext = False IsNew = False
					OperandVar678 = "encounter_ui_enlist";
					subContext677.SetUiMarker(( (OperandVar678)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar679 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar679 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar679)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar685 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable680 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable680 != null)
			{
				Named StoredVariable681 = ((Named)StoredVariable680.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable681 != null)
				{
					System.Boolean ifResult682; //IsContext = False IsNew = False
					
					System.Boolean OperandVar684 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable680 != null)
					{
						System.Boolean prop683 = StoredVariable680.Act; //IsContext = False IsNew = False
						OperandVar684 = prop683;
					}
					
					
					if(ifResult682 = ( ( (OperandVar684))) == ( ( (true))))
					{
						applicable = true;
						OperandVar685 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar685);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.4f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject enc = new UnityEngine.GameObject("enc"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject enc686 = enc; //IsContext = True IsNew = False
				Encounter AddContext687 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext687 ContextSwitchInterpreter
					if(AddContext687 != null)
					{
						UnityEngine.GameObject OperandVar688 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar688 = root;
						AddContext687.Context = (UnityEngine.GameObject)( (OperandVar688));
					}
				}
				Markers AddContext689 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext690 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext691 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext691 ContextSwitchInterpreter
					if(AddContext691 != null)
					{
						System.String OperandVar692 = default(System.String); //IsContext = False IsNew = False
						OperandVar692 = "main_name";
						
						
						AddContext691.Set(( (OperandVar692)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar706 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable693 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable693 != null)
			{
				Markers StoredVariable694 = ((Markers)StoredVariable693.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable694 != null)
				{
					System.Boolean ifResult695; //IsContext = False IsNew = False
					
					System.Boolean OperandVar702 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable693 != null)
					{
						UnityEngine.GameObject prop696 = StoredVariable693.ShowedObject; //IsContext = False IsNew = False
						if(prop696 != null)
						{
							System.Boolean ifResult697; //IsContext = False IsNew = False
							System.Boolean OperandVar701 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar699 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable698 = ((Place)prop696.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable698 != null)
							{
								OperandVar699 = StoredVariable698;
							}
							System.Boolean prop700 = External.Has( (OperandVar699)); //IsContext = False IsNew = False
							OperandVar701 = prop700;
							if(ifResult697 =  (OperandVar701))
							{
								OperandVar702 = ifResult697;
							}
						}
					}
					
					System.Boolean OperandVar705 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar703 = default(System.String); //IsContext = False IsNew = False
					OperandVar703 = "place_ui_cards_list";
					System.Boolean prop704 = StoredVariable694.HasMarker( (OperandVar703)); //IsContext = False IsNew = False
					OperandVar705 = prop704;
					if(ifResult695 = ( ( (OperandVar702))) && ( (!(OperandVar705))))
					{
						applicable = true;
						OperandVar706 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar706);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext707 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext707 ContextSwitchInterpreter
				if(subContext707 != null)
				{
					System.String OperandVar708 = default(System.String); //IsContext = False IsNew = False
					OperandVar708 = "place_ui_cards_list";
					subContext707.SetUiMarker(( (OperandVar708)).ToString());
				}
			}
			Place OperandVar712 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable709 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable709 != null)
			{
				UnityEngine.GameObject prop710 = StoredVariable709.ShowedObject; //IsContext = False IsNew = False
				if(prop710 != null)
				{
					Place StoredVariable711 = ((Place)prop710.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable711 != null)
					{
						OperandVar712 = StoredVariable711;
					}
				}
			}
			Place pl =  (OperandVar712); //IsContext = False IsNew = False
			System.String OperandVar713 = default(System.String); //IsContext = False IsNew = False
			OperandVar713 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx714 = External.SpawnPrefab(( (OperandVar713)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx714 ContextPropertySwitchInterpreter
				if(FuncCtx714 != null)
				{
					
					{
						AgentsUI subContext715 = (AgentsUI)FuncCtx714.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext715 ContextSwitchInterpreter
						if(subContext715 != null)
						{
							Place OperandVar716 = default(Place); //IsContext = False IsNew = False
							OperandVar716 = pl;
							subContext715.TargetPlace = (Place)( (OperandVar716));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext717 = (CardsHolderAgentsAdapter)FuncCtx714.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext717 ContextSwitchInterpreter
						if(subContext717 != null)
						{
							Place OperandVar718 = default(Place); //IsContext = False IsNew = False
							OperandVar718 = pl;
							subContext717.TargetPlace = (Place)( (OperandVar718));
						}
					}
					UnityEngine.GameObject OperandVar719 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar719 = FuncCtx714;
					UnityEngine.GameObject OperandVar720 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar720 = root;
					External.SetParent((UnityEngine.GameObject)( (OperandVar719)),(UnityEngine.GameObject)( (OperandVar720)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false)]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar726 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable721 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable721 != null)
			{
				System.Boolean ifResult722; //IsContext = False IsNew = False
				System.Boolean OperandVar725 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop723 = StoredVariable721.ShowedObject; //IsContext = False IsNew = False
				if(prop723 != null)
				{
					Place StoredVariable724 = ((Place)prop723.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable724 != null)
					{
						applicable = true;
						OperandVar725 = applicable;
					}
				}
				if(ifResult722 =  (OperandVar725))
				{
					applicable = true;
					OperandVar726 = applicable;
				}
			}
			return (System.Boolean) (OperandVar726);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			TextField ContextVar727 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement TextField ContextVar727 ContextSwitchInterpreter
				if(ContextVar727 != null)
				{
					
					ContextVar727.Label = (System.String)( ("size"));
					System.Int32 OperandVar732 = default(System.Int32); //IsContext = False IsNew = False
					UiObject StoredVariable728 = ((UiObject)ContextVar727.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
					if(StoredVariable728 != null)
					{
						UnityEngine.GameObject prop729 = StoredVariable728.ShowedObject; //IsContext = False IsNew = False
						if(prop729 != null)
						{
							Place StoredVariable730 = ((Place)prop729.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable730 != null)
							{
								System.Int32 prop731 = StoredVariable730.Size; //IsContext = False IsNew = False
								OperandVar732 = prop731;
							}
						}
					}
					ContextVar727.Show(( (OperandVar732)).ToString());
					
					{
						UnityEngine.UI.LayoutElement subContext733 = ContextVar727.Layout; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.UI.LayoutElement subContext733 ContextPropertySwitchInterpreter
						if(subContext733 != null)
						{
							
							subContext733.minHeight = (System.Single)( (20f));
						}
					}
				}
			}
			Entity EntVar734 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar734 != null) EntVar734.ComponentAdded();
		}
        }
    }
}
