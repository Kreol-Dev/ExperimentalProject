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
			return (System.Single)( ( (0.2f))) + ( ( (OperandVar145))) + ( ( (OperandVar147)));
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
			
			
			
			System.Single OperandVar324 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable320 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable320 != null)
			{
				UnityEngine.GameObject prop321 = StoredVariable320.CurrentCampaign; //IsContext = False IsNew = False
				if(prop321 != null)
				{
					Blackboards.campaign_event StoredVariable322 = ((Blackboards.campaign_event)prop321.GetComponent(typeof(Blackboards.campaign_event))); //IsContext = False IsNew = False
					if(StoredVariable322 != null)
					{
						System.Single prop323 = StoredVariable322.ForcesInvolved; //IsContext = False IsNew = False
						OperandVar324 = prop323;
					}
				}
			}
			System.Single OperandVar331 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable325 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable325 != null)
			{
				UnityEngine.GameObject prop326 = StoredVariable325.Enemy; //IsContext = False IsNew = False
				if(prop326 != null)
				{
					Blackboards.ruler_role StoredVariable327 = ((Blackboards.ruler_role)prop326.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
					if(StoredVariable327 != null)
					{
						UnityEngine.GameObject prop328 = StoredVariable327.CurrentCampaign; //IsContext = False IsNew = False
						if(prop328 != null)
						{
							Blackboards.campaign_event StoredVariable329 = ((Blackboards.campaign_event)prop328.GetComponent(typeof(Blackboards.campaign_event))); //IsContext = False IsNew = False
							if(StoredVariable329 != null)
							{
								System.Single prop330 = StoredVariable329.ForcesInvolved; //IsContext = False IsNew = False
								OperandVar331 = prop330;
							}
						}
					}
				}
			}
			
			
			
			
			
			System.Single OperandVar333 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable320 != null)
			{
				System.Single prop332 = StoredVariable320.People; //IsContext = False IsNew = False
				OperandVar333 = prop332;
			}
			
			
			return (System.Single)( ( (( (OperandVar324)) / ( (OperandVar331))))) - ( ( (1f))) + ( ( (( ( (OperandVar333))) - ( ( (0.5f))))));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject gather_reinforcements = new UnityEngine.GameObject("gather_reinforcements"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject gather_reinforcements334 = gather_reinforcements; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext335 = (Blackboards.notify_event)gather_reinforcements.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext335 ContextSwitchInterpreter
					if(AddContext335 != null)
					{
						UnityEngine.GameObject OperandVar336 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar336 = root;
						AddContext335.Who = (UnityEngine.GameObject)( (OperandVar336));
						
						AddContext335.Data = (System.String)( ("gather_reinforcements"));
					}
				}
			}
			
			{
				Blackboards.ruler_role subContext337 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext337 ContextSwitchInterpreter
				if(subContext337 != null)
				{
					
					System.Single OperandVar339 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop338 = subContext337.Forces; //IsContext = False IsNew = False
					OperandVar339 = prop338;
					
					
					subContext337.Forces = (System.Single)(( ( (OperandVar339))) + ( ( (7f))));
					
					System.Single OperandVar341 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop340 = subContext337.People; //IsContext = False IsNew = False
					OperandVar341 = prop340;
					
					
					subContext337.People = (System.Single)(( ( (OperandVar341))) - ( ( (0.1f))));
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
			
			System.Boolean OperandVar349 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable342 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable342 != null)
			{
				Blackboards.ruler_role StoredVariable343 = ((Blackboards.ruler_role)StoredVariable342.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable343 != null)
				{
					System.Boolean ifResult344; //IsContext = False IsNew = False
					
					
					System.Single OperandVar346 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop345 = StoredVariable343.People; //IsContext = False IsNew = False
					OperandVar346 = prop345;
					
					
					
					System.Boolean OperandVar348 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable342 != null)
					{
						System.Boolean prop347 = StoredVariable342.IsActive; //IsContext = False IsNew = False
						OperandVar348 = prop347;
					}
					if(ifResult344 = ( (( ( (OperandVar346))) < ( ( (1f))))) && ( (!(OperandVar348))))
					{
						applicable = true;
						OperandVar349 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar349);
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
				Blackboards.ruler_role subContext350 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext350 ContextSwitchInterpreter
				if(subContext350 != null)
				{
					System.Single OperandVar352 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop351 = subContext350.People; //IsContext = False IsNew = False
					OperandVar352 = prop351;
					
					subContext350.People = (System.Single)(( (OperandVar352)) * ( (1.2f)));
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
			
			System.Boolean OperandVar365 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable353 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable353 != null)
			{
				Blackboards.ruler_role StoredVariable354 = ((Blackboards.ruler_role)StoredVariable353.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable354 != null)
				{
					Blackboards.foe_role StoredVariable355 = ((Blackboards.foe_role)StoredVariable354.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable355 != null)
					{
						System.Boolean ifResult356; //IsContext = False IsNew = False
						
						System.Boolean OperandVar358 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable353 != null)
						{
							System.Boolean prop357 = StoredVariable353.IsActive; //IsContext = False IsNew = False
							OperandVar358 = prop357;
						}
						
						System.Boolean OperandVar364 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar360 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable354 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop359 = StoredVariable354.AtWarWith; //IsContext = False IsNew = False
							if(prop359 != null)
							{
								OperandVar360 = prop359;
							}
						}
						UnityEngine.GameObject OperandVar362 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop361 = StoredVariable355.Enemy; //IsContext = False IsNew = False
						if(prop361 != null)
						{
							OperandVar362 = prop361;
						}
						System.Boolean prop363 = External.Contains( (OperandVar360), (OperandVar362)); //IsContext = False IsNew = False
						OperandVar364 = prop363;
						if(ifResult356 = ( ( (OperandVar358))) && ( ( (OperandVar364))))
						{
							applicable = true;
							OperandVar365 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar365);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar368 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable366 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable366 != null)
			{
				System.Single prop367 = StoredVariable366.ThreatLevel; //IsContext = False IsNew = False
				OperandVar368 = prop367;
			}
			
			return (System.Single)( (OperandVar368)) * ( (0.3f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject wunder_waffe = new UnityEngine.GameObject("wunder_waffe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wunder_waffe369 = wunder_waffe; //IsContext = True IsNew = False
				Actor AddContext370 = (Actor)wunder_waffe.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.buildable AddContext371 = (Blackboards.buildable)wunder_waffe.AddComponent(typeof(Blackboards.buildable)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.buildable AddContext371 ContextSwitchInterpreter
					if(AddContext371 != null)
					{
						
						AddContext371.Cost = (System.Single)( (20f));
					}
				}
				Blackboards.old_weapon AddContext372 = (Blackboards.old_weapon)wunder_waffe.AddComponent(typeof(Blackboards.old_weapon)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wunder_waffe, 0.1f);
			
			{
				Blackboards.ruler_role subContext373 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext373 ContextSwitchInterpreter
				if(subContext373 != null)
				{
					UnityEngine.GameObject OperandVar374 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar374 = wunder_waffe;
					subContext373.Wunderwaffe = (UnityEngine.GameObject)( (OperandVar374));
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
			
			System.Boolean OperandVar384 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable375 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable375 != null)
			{
				Blackboards.ruler_role StoredVariable376 = ((Blackboards.ruler_role)StoredVariable375.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable376 != null)
				{
					System.Boolean ifResult377; //IsContext = False IsNew = False
					
					System.Boolean OperandVar381 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop378 = StoredVariable376.Wunderwaffe; //IsContext = False IsNew = False
					if(prop378 != null)
					{
						Blackboards.old_weapon StoredVariable379 = ((Blackboards.old_weapon)prop378.GetComponent(typeof(Blackboards.old_weapon))); //IsContext = False IsNew = False
						if(StoredVariable379 != null)
						{
							Blackboards.buildable StoredVariable380 = ((Blackboards.buildable)StoredVariable379.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
							if(StoredVariable380 != null)
							{
								applicable = true;
								OperandVar381 = applicable;
							}
						}
					}
					
					System.Boolean OperandVar383 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable375 != null)
					{
						System.Boolean prop382 = StoredVariable375.IsActive; //IsContext = False IsNew = False
						OperandVar383 = prop382;
					}
					if(ifResult377 = ( ( (OperandVar381))) && ( (!(OperandVar383))))
					{
						applicable = true;
						OperandVar384 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar384);
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
				UnityEngine.GameObject genius385 = genius; //IsContext = True IsNew = False
				Markers AddContext386 = (Markers)genius.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Actor AddContext387 = (Actor)genius.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Blackboards.worker AddContext388 = (Blackboards.worker)genius.AddComponent(typeof(Blackboards.worker)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.worker AddContext388 ContextSwitchInterpreter
					if(AddContext388 != null)
					{
						UnityEngine.GameObject OperandVar389 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar389 = root;
						AddContext388.WorksFor = (UnityEngine.GameObject)( (OperandVar389));
					}
				}
				Blackboards.builder AddContext390 = (Blackboards.builder)genius.AddComponent(typeof(Blackboards.builder)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(genius, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class lead_campaign : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar410 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable391 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable391 != null)
			{
				Blackboards.ruler_role StoredVariable392 = ((Blackboards.ruler_role)StoredVariable391.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable392 != null)
				{
					Blackboards.foe_role StoredVariable393 = ((Blackboards.foe_role)StoredVariable392.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable393 != null)
					{
						System.Boolean ifResult394; //IsContext = False IsNew = False
						
						System.Boolean OperandVar396 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable391 != null)
						{
							System.Boolean prop395 = StoredVariable391.IsActive; //IsContext = False IsNew = False
							OperandVar396 = prop395;
						}
						
						System.Boolean OperandVar402 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar398 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable392 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop397 = StoredVariable392.AtWarWith; //IsContext = False IsNew = False
							if(prop397 != null)
							{
								OperandVar398 = prop397;
							}
						}
						UnityEngine.GameObject OperandVar400 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop399 = StoredVariable393.Enemy; //IsContext = False IsNew = False
						if(prop399 != null)
						{
							OperandVar400 = prop399;
						}
						System.Boolean prop401 = External.Contains( (OperandVar398), (OperandVar400)); //IsContext = False IsNew = False
						OperandVar402 = prop401;
						
						System.Boolean OperandVar405 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop403 = StoredVariable393.Enemy; //IsContext = False IsNew = False
						if(prop403 != null)
						{
							Blackboards.ruler_role StoredVariable404 = ((Blackboards.ruler_role)prop403.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable404 != null)
							{
								applicable = true;
								OperandVar405 = applicable;
							}
						}
						
						System.Boolean OperandVar409 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar407 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable392 != null)
						{
							UnityEngine.GameObject prop406 = StoredVariable392.CurrentCampaign; //IsContext = False IsNew = False
							if(prop406 != null)
							{
								OperandVar407 = prop406;
							}
						}
						System.Boolean prop408 = External.Has( (OperandVar407)); //IsContext = False IsNew = False
						OperandVar409 = prop408;
						if(ifResult394 = ( ( (OperandVar396))) && ( ( (OperandVar402))) && ( ( (OperandVar405))) && ( (!(OperandVar409))))
						{
							applicable = true;
							OperandVar410 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar410);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar413 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable411 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable411 != null)
			{
				System.Single prop412 = StoredVariable411.ThreatLevel; //IsContext = False IsNew = False
				OperandVar413 = prop412;
			}
			return (System.Single)( (1f)) / ( (OperandVar413));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject campaign = new UnityEngine.GameObject("campaign"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject campaign414 = campaign; //IsContext = True IsNew = False
				Event AddContext415 = (Event)campaign.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext415 ContextSwitchInterpreter
					if(AddContext415 != null)
					{
						UnityEngine.GameObject OperandVar416 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar416 = root;
						AddContext415.Context = (UnityEngine.GameObject)( (OperandVar416));
					}
				}
				Blackboards.targeted_event AddContext417 = (Blackboards.targeted_event)campaign.AddComponent(typeof(Blackboards.targeted_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.targeted_event AddContext417 ContextSwitchInterpreter
					if(AddContext417 != null)
					{
						UnityEngine.GameObject OperandVar420 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.foe_role StoredVariable418 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
						if(StoredVariable418 != null)
						{
							UnityEngine.GameObject prop419 = StoredVariable418.Enemy; //IsContext = False IsNew = False
							if(prop419 != null)
							{
								OperandVar420 = prop419;
							}
						}
						AddContext417.Target = (UnityEngine.GameObject)( (OperandVar420));
					}
				}
				Blackboards.campaign_event AddContext421 = (Blackboards.campaign_event)campaign.AddComponent(typeof(Blackboards.campaign_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.campaign_event AddContext421 ContextSwitchInterpreter
					if(AddContext421 != null)
					{
						System.Single OperandVar424 = default(System.Single); //IsContext = False IsNew = False
						Blackboards.ruler_role StoredVariable422 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
						if(StoredVariable422 != null)
						{
							System.Single prop423 = StoredVariable422.Forces; //IsContext = False IsNew = False
							OperandVar424 = prop423;
						}
						AddContext421.ForcesInvolved = (System.Single)( (OperandVar424));
					}
				}
				Markers AddContext425 = (Markers)campaign.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(campaign, 0.1f);
			
			{
				Blackboards.ruler_role subContext426 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext426 ContextSwitchInterpreter
				if(subContext426 != null)
				{
					
					subContext426.Forces = (System.Single)( (0f));
				}
			}
			
			{
				Blackboards.ruler_role subContext427 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext427 ContextSwitchInterpreter
				if(subContext427 != null)
				{
					UnityEngine.GameObject OperandVar428 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar428 = campaign;
					subContext427.CurrentCampaign = (UnityEngine.GameObject)( (OperandVar428));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class end_campaign : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar448 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable429 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable429 != null)
			{
				Blackboards.ruler_role StoredVariable430 = ((Blackboards.ruler_role)StoredVariable429.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable430 != null)
				{
					Blackboards.foe_role StoredVariable431 = ((Blackboards.foe_role)StoredVariable430.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable431 != null)
					{
						System.Boolean ifResult432; //IsContext = False IsNew = False
						
						System.Boolean OperandVar434 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable429 != null)
						{
							System.Boolean prop433 = StoredVariable429.IsActive; //IsContext = False IsNew = False
							OperandVar434 = prop433;
						}
						
						System.Boolean OperandVar440 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar436 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable430 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop435 = StoredVariable430.AtWarWith; //IsContext = False IsNew = False
							if(prop435 != null)
							{
								OperandVar436 = prop435;
							}
						}
						UnityEngine.GameObject OperandVar438 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop437 = StoredVariable431.Enemy; //IsContext = False IsNew = False
						if(prop437 != null)
						{
							OperandVar438 = prop437;
						}
						System.Boolean prop439 = External.Contains( (OperandVar436), (OperandVar438)); //IsContext = False IsNew = False
						OperandVar440 = prop439;
						
						System.Boolean OperandVar443 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop441 = StoredVariable431.Enemy; //IsContext = False IsNew = False
						if(prop441 != null)
						{
							Blackboards.ruler_role StoredVariable442 = ((Blackboards.ruler_role)prop441.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable442 != null)
							{
								applicable = true;
								OperandVar443 = applicable;
							}
						}
						
						System.Boolean OperandVar447 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar445 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable430 != null)
						{
							UnityEngine.GameObject prop444 = StoredVariable430.CurrentCampaign; //IsContext = False IsNew = False
							if(prop444 != null)
							{
								OperandVar445 = prop444;
							}
						}
						System.Boolean prop446 = External.Has( (OperandVar445)); //IsContext = False IsNew = False
						OperandVar447 = prop446;
						if(ifResult432 = ( ( (OperandVar434))) && ( ( (OperandVar440))) && ( ( (OperandVar443))) && ( ( (OperandVar447))))
						{
							applicable = true;
							OperandVar448 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar448);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar453 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.ruler_role StoredVariable449 = ((Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
			if(StoredVariable449 != null)
			{
				UnityEngine.GameObject prop450 = StoredVariable449.CurrentCampaign; //IsContext = False IsNew = False
				if(prop450 != null)
				{
					Blackboards.campaign_event StoredVariable451 = ((Blackboards.campaign_event)prop450.GetComponent(typeof(Blackboards.campaign_event))); //IsContext = False IsNew = False
					if(StoredVariable451 != null)
					{
						System.Single prop452 = StoredVariable451.ForcesInvolved; //IsContext = False IsNew = False
						OperandVar453 = prop452;
					}
				}
			}
			return (System.Single)( ( (1f))) - ( ( (OperandVar453)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Single return_forces =  (0f); //IsContext = False IsNew = False
			
			{
				Blackboards.ruler_role subContext454 = (Blackboards.ruler_role)root.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.ruler_role subContext454 ContextSwitchInterpreter
				if(subContext454 != null)
				{
					
					System.Single OperandVar456 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop455 = subContext454.Forces; //IsContext = False IsNew = False
					OperandVar456 = prop455;
					
					System.Single OperandVar457 = default(System.Single); //IsContext = False IsNew = False
					OperandVar457 = return_forces;
					subContext454.Forces = (System.Single)(( ( (OperandVar456))) + ( ( (OperandVar457))));
				}
			}
			UnityEngine.GameObject OperandVar459 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			UnityEngine.GameObject prop458 = External.Nothing(); //IsContext = False IsNew = False
			if(prop458 != null)
			{
				OperandVar459 = prop458;
			}
			UnityEngine.GameObject current_campaign =  (OperandVar459); //IsContext = False IsNew = False
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
			
			System.Boolean OperandVar475 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable460 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable460 != null)
			{
				Blackboards.builder StoredVariable461 = ((Blackboards.builder)StoredVariable460.GetComponent(typeof(Blackboards.builder))); //IsContext = False IsNew = False
				if(StoredVariable461 != null)
				{
					Blackboards.worker StoredVariable462 = ((Blackboards.worker)StoredVariable461.GetComponent(typeof(Blackboards.worker))); //IsContext = False IsNew = False
					if(StoredVariable462 != null)
					{
						System.Boolean ifResult463; //IsContext = False IsNew = False
						
						System.Boolean OperandVar465 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable460 != null)
						{
							System.Boolean prop464 = StoredVariable460.IsActive; //IsContext = False IsNew = False
							OperandVar465 = prop464;
						}
						
						System.Boolean OperandVar474 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop466 = StoredVariable462.WorksFor; //IsContext = False IsNew = False
						if(prop466 != null)
						{
							Blackboards.ruler_role StoredVariable467 = ((Blackboards.ruler_role)prop466.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable467 != null)
							{
								System.Boolean ifResult468; //IsContext = False IsNew = False
								
								Blackboards.ruler_role OperandVar469 = default(Blackboards.ruler_role); //IsContext = False IsNew = False
								OperandVar469 = StoredVariable467;
								
								System.Boolean OperandVar473 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject prop470 = StoredVariable467.Wunderwaffe; //IsContext = False IsNew = False
								if(prop470 != null)
								{
									Blackboards.buildable StoredVariable471 = ((Blackboards.buildable)prop470.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
									if(StoredVariable471 != null)
									{
										System.Boolean prop472 = StoredVariable471.Finished; //IsContext = False IsNew = False
										OperandVar473 = prop472;
									}
								}
								if(ifResult468 = ( ( (OperandVar469))) && ( (!(OperandVar473))))
								{
									OperandVar474 = ifResult468;
								}
							}
						}
						if(ifResult463 = ( ( (OperandVar465))) && ( ( (OperandVar474))))
						{
							applicable = true;
							OperandVar475 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar475);
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
				UnityEngine.GameObject build_wunderwaffe476 = build_wunderwaffe; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext477 = (Blackboards.notify_event)build_wunderwaffe.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext477 ContextSwitchInterpreter
					if(AddContext477 != null)
					{
						UnityEngine.GameObject OperandVar478 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar478 = root;
						AddContext477.Who = (UnityEngine.GameObject)( (OperandVar478));
						
						AddContext477.Data = (System.String)( ("build_wunderwaffe"));
					}
				}
			}
			
			{
				Blackboards.worker subContext479 = (Blackboards.worker)root.GetComponent(typeof(Blackboards.worker)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.worker subContext479 ContextSwitchInterpreter
				if(subContext479 != null)
				{
					
					{
						UnityEngine.GameObject subContext480 = subContext479.WorksFor; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext480 ContextPropertySwitchInterpreter
						if(subContext480 != null)
						{
							
							{
								Blackboards.ruler_role subContext481 = (Blackboards.ruler_role)subContext480.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext481 ContextSwitchInterpreter
								if(subContext481 != null)
								{
									
									{
										UnityEngine.GameObject subContext482 = subContext481.Wunderwaffe; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.GameObject subContext482 ContextPropertySwitchInterpreter
										if(subContext482 != null)
										{
											
											{
												Blackboards.buildable subContext483 = (Blackboards.buildable)subContext482.GetComponent(typeof(Blackboards.buildable)); //IsContext = True IsNew = False
												//ContextStatement Blackboards.buildable subContext483 ContextSwitchInterpreter
												if(subContext483 != null)
												{
													
													System.Single OperandVar485 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop484 = subContext483.CurrentInvestment; //IsContext = False IsNew = False
													OperandVar485 = prop484;
													
													
													subContext483.CurrentInvestment = (System.Single)(( ( (OperandVar485))) + ( ( (5f))));
													
													System.Single OperandVar487 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop486 = subContext483.CurrentInvestment; //IsContext = False IsNew = False
													OperandVar487 = prop486;
													
													System.Single OperandVar489 = default(System.Single); //IsContext = False IsNew = False
													System.Single prop488 = subContext483.Cost; //IsContext = False IsNew = False
													OperandVar489 = prop488;
													if(( ( (OperandVar487))) >= ( ( (OperandVar489))))
													{
														
														subContext483.Finished = (System.Boolean)( (true));
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
			
			System.Boolean OperandVar513 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable490 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable490 != null)
			{
				Blackboards.ruler_role StoredVariable491 = ((Blackboards.ruler_role)StoredVariable490.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable491 != null)
				{
					Blackboards.foe_role StoredVariable492 = ((Blackboards.foe_role)StoredVariable491.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
					if(StoredVariable492 != null)
					{
						System.Boolean ifResult493; //IsContext = False IsNew = False
						
						System.Boolean OperandVar495 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable490 != null)
						{
							System.Boolean prop494 = StoredVariable490.IsActive; //IsContext = False IsNew = False
							OperandVar495 = prop494;
						}
						
						System.Boolean OperandVar501 = default(System.Boolean); //IsContext = False IsNew = False
						System.Collections.Generic.List<UnityEngine.GameObject> OperandVar497 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
						if(StoredVariable491 != null)
						{
							System.Collections.Generic.List<UnityEngine.GameObject> prop496 = StoredVariable491.AtWarWith; //IsContext = False IsNew = False
							if(prop496 != null)
							{
								OperandVar497 = prop496;
							}
						}
						UnityEngine.GameObject OperandVar499 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						UnityEngine.GameObject prop498 = StoredVariable492.Enemy; //IsContext = False IsNew = False
						if(prop498 != null)
						{
							OperandVar499 = prop498;
						}
						System.Boolean prop500 = External.Contains( (OperandVar497), (OperandVar499)); //IsContext = False IsNew = False
						OperandVar501 = prop500;
						
						System.Boolean OperandVar504 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject prop502 = StoredVariable492.Enemy; //IsContext = False IsNew = False
						if(prop502 != null)
						{
							Blackboards.ruler_role StoredVariable503 = ((Blackboards.ruler_role)prop502.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
							if(StoredVariable503 != null)
							{
								applicable = true;
								OperandVar504 = applicable;
							}
						}
						
						System.Boolean OperandVar508 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar506 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable491 != null)
						{
							UnityEngine.GameObject prop505 = StoredVariable491.Wunderwaffe; //IsContext = False IsNew = False
							if(prop505 != null)
							{
								OperandVar506 = prop505;
							}
						}
						System.Boolean prop507 = External.Has( (OperandVar506)); //IsContext = False IsNew = False
						OperandVar508 = prop507;
						
						System.Boolean OperandVar512 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable491 != null)
						{
							UnityEngine.GameObject prop509 = StoredVariable491.Wunderwaffe; //IsContext = False IsNew = False
							if(prop509 != null)
							{
								Blackboards.buildable StoredVariable510 = ((Blackboards.buildable)prop509.GetComponent(typeof(Blackboards.buildable))); //IsContext = False IsNew = False
								if(StoredVariable510 != null)
								{
									System.Boolean prop511 = StoredVariable510.Finished; //IsContext = False IsNew = False
									OperandVar512 = prop511;
								}
							}
						}
						if(ifResult493 = ( ( (OperandVar495))) && ( ( (OperandVar501))) && ( ( (OperandVar504))) && ( ( (OperandVar508))) && ( ( (OperandVar512))))
						{
							applicable = true;
							OperandVar513 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar513);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar516 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.foe_role StoredVariable514 = ((Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role))); //IsContext = False IsNew = False
			if(StoredVariable514 != null)
			{
				System.Single prop515 = StoredVariable514.ThreatLevel; //IsContext = False IsNew = False
				OperandVar516 = prop515;
			}
			
			return (System.Single)( (OperandVar516)) * ( (0.5f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject test_wunderwaffe = new UnityEngine.GameObject("test_wunderwaffe"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject test_wunderwaffe517 = test_wunderwaffe; //IsContext = True IsNew = False
				Blackboards.notify_event AddContext518 = (Blackboards.notify_event)test_wunderwaffe.AddComponent(typeof(Blackboards.notify_event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.notify_event AddContext518 ContextSwitchInterpreter
					if(AddContext518 != null)
					{
						UnityEngine.GameObject OperandVar519 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar519 = root;
						AddContext518.Who = (UnityEngine.GameObject)( (OperandVar519));
						
						AddContext518.Data = (System.String)( ("test_wunderwaffe"));
					}
				}
			}
			
			{
				Blackboards.foe_role subContext520 = (Blackboards.foe_role)root.GetComponent(typeof(Blackboards.foe_role)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.foe_role subContext520 ContextSwitchInterpreter
				if(subContext520 != null)
				{
					
					{
						UnityEngine.GameObject subContext521 = subContext520.Enemy; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext521 ContextPropertySwitchInterpreter
						if(subContext521 != null)
						{
							
							{
								Blackboards.ruler_role subContext522 = (Blackboards.ruler_role)subContext521.GetComponent(typeof(Blackboards.ruler_role)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.ruler_role subContext522 ContextSwitchInterpreter
								if(subContext522 != null)
								{
									
									System.Single OperandVar524 = default(System.Single); //IsContext = False IsNew = False
									System.Single prop523 = subContext522.Forces; //IsContext = False IsNew = False
									OperandVar524 = prop523;
									
									
									subContext522.Forces = (System.Single)(( ( (OperandVar524))) - ( ( (10f))));
									
									subContext522.People = (System.Single)( (0f));
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
			
			System.Boolean OperandVar529 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable525 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable525 != null)
			{
				System.Boolean ifResult526; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar528 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop527 = StoredVariable525.Places; //IsContext = False IsNew = False
				if(prop527 != null)
				{
					OperandVar528 = prop527;
				}
				
				
				if(ifResult526 = ( ( (OperandVar528 != null ? OperandVar528.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar529 = applicable;
				}
			}
			return (System.Boolean) (OperandVar529);
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
				Space subContext530 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext530 ContextSwitchInterpreter
				if(subContext530 != null)
				{
					
					subContext530.Size = (System.Int32)( (5f));
					System.Single OperandVar532 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop531 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar532 = prop531;
					for (int i = 0; i <  (OperandVar532); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc533 = loc; //IsContext = True IsNew = False
							Entity AddContext534 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext534 ContextSwitchInterpreter
								if(AddContext534 != null)
								{
									UnityEngine.Vector3 OperandVar544 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar538 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar536 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop535 = External.MapX(); //IsContext = False IsNew = False
									OperandVar536 = prop535;
									System.Single prop537 = External.Random( (0f), (OperandVar536)); //IsContext = False IsNew = False
									OperandVar538 = prop537;
									System.Single OperandVar542 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar540 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop539 = External.MapX(); //IsContext = False IsNew = False
									OperandVar540 = prop539;
									System.Single prop541 = External.Random( (0f), (OperandVar540)); //IsContext = False IsNew = False
									OperandVar542 = prop541;
									UnityEngine.Vector3 prop543 = External.Vec( (OperandVar538), (OperandVar542)); //IsContext = False IsNew = False
									OperandVar544 = prop543;
									AddContext534.Position = (UnityEngine.Vector3)( (OperandVar544));
								}
							}
							Place AddContext545 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext545 ContextSwitchInterpreter
								if(AddContext545 != null)
								{
									System.Single OperandVar547 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop546 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar547 = prop546;
									AddContext545.Size = (System.Int32)( (OperandVar547));
								}
							}
							Markers AddContext548 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext548 ContextSwitchInterpreter
								if(AddContext548 != null)
								{
									System.String OperandVar549 = default(System.String); //IsContext = False IsNew = False
									OperandVar549 = "history_place";
									AddContext548.SetMarker(( (OperandVar549)).ToString());
								}
							}
							Named AddContext550 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext550 ContextSwitchInterpreter
								if(AddContext550 != null)
								{
									
									
									
									AddContext550.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar553 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar551 = default(System.String); //IsContext = False IsNew = False
									OperandVar551 = "human_name";
									System.String prop552 = External.RandomName( (OperandVar551)); //IsContext = False IsNew = False
									if(prop552 != null)
									{
										OperandVar553 = prop552;
									}
									AddContext550.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar553)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc, 0.1f);
						Place OperandVar555 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable554 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable554 != null)
						{
							OperandVar555 = StoredVariable554;
						}
						subContext530.Attach((Place)( (OperandVar555)));
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
			
			System.Boolean OperandVar569 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable556 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable556 != null)
			{
				Markers StoredVariable557 = ((Markers)StoredVariable556.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable557 != null)
				{
					System.Boolean ifResult558; //IsContext = False IsNew = False
					
					System.Boolean OperandVar565 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable556 != null)
					{
						UnityEngine.GameObject prop559 = StoredVariable556.ShowedObject; //IsContext = False IsNew = False
						if(prop559 != null)
						{
							System.Boolean ifResult560; //IsContext = False IsNew = False
							System.Boolean OperandVar564 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar562 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable561 = ((Named)prop559.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable561 != null)
							{
								OperandVar562 = StoredVariable561;
							}
							System.Boolean prop563 = External.Has( (OperandVar562)); //IsContext = False IsNew = False
							OperandVar564 = prop563;
							if(ifResult560 =  (OperandVar564))
							{
								OperandVar565 = ifResult560;
							}
						}
					}
					
					System.Boolean OperandVar568 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar566 = default(System.String); //IsContext = False IsNew = False
					OperandVar566 = "named_ui_marker";
					System.Boolean prop567 = StoredVariable557.HasMarker( (OperandVar566)); //IsContext = False IsNew = False
					OperandVar568 = prop567;
					if(ifResult558 = ( ( (OperandVar565))) && ( (!(OperandVar568))))
					{
						applicable = true;
						OperandVar569 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar569);
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
				Markers subContext570 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext570 ContextSwitchInterpreter
				if(subContext570 != null)
				{
					System.String OperandVar571 = default(System.String); //IsContext = False IsNew = False
					OperandVar571 = "named_ui_marker";
					subContext570.SetUiMarker(( (OperandVar571)).ToString());
				}
			}
			
			{
				UiObject subContext572 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext572 ContextSwitchInterpreter
				if(subContext572 != null)
				{
					Named OperandVar575 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop573 = subContext572.ShowedObject; //IsContext = False IsNew = False
					if(prop573 != null)
					{
						Named StoredVariable574 = ((Named)prop573.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable574 != null)
						{
							OperandVar575 = StoredVariable574;
						}
					}
					Named showed_named =  (OperandVar575); //IsContext = False IsNew = False
					TextField ContextVar576 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar576 ContextSwitchInterpreter
						if(ContextVar576 != null)
						{
							System.String OperandVar578 = default(System.String); //IsContext = False IsNew = False
							System.String prop577 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop577 != null)
							{
								OperandVar578 = prop577;
							}
							ContextVar576.Show(( (OperandVar578)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda579 = () => 
									{
										System.String OperandVar581 = default(System.String); //IsContext = False IsNew = False
										System.String prop580 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop580 != null)
										{
											OperandVar581 = prop580;
										}
										ContextVar576.Show(( (OperandVar581)).ToString());
									};
									showed_named.OnUpdate(Lambda579);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext582 = ContextVar576.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext582 ContextPropertySwitchInterpreter
								if(subContext582 != null)
								{
									
									subContext582.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar583 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar583 != null) EntVar583.ComponentAdded();
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
			
			System.Boolean OperandVar592 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable584 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable584 != null)
			{
				Place StoredVariable585 = ((Place)StoredVariable584.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable585 != null)
				{
					System.Boolean ifResult586; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar588 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop587 = StoredVariable585.Agents; //IsContext = False IsNew = False
					if(prop587 != null)
					{
						OperandVar588 = prop587;
					}
					
					
					
					System.Boolean OperandVar591 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar589 = default(System.String); //IsContext = False IsNew = False
					OperandVar589 = "agents_pool";
					System.Boolean prop590 = StoredVariable584.HasMarker( (OperandVar589)); //IsContext = False IsNew = False
					OperandVar591 = prop590;
					if(ifResult586 = ( (( ( (OperandVar588 != null ? OperandVar588.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar591))))
					{
						applicable = true;
						OperandVar592 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar592);
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
				Place subContext593 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext593 ContextSwitchInterpreter
				if(subContext593 != null)
				{
					
					subContext593.Size = (System.Int32)( (5f));
					System.Single OperandVar595 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop594 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar595 = prop594;
					for (int i = 0; i <  (OperandVar595); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag596 = ag; //IsContext = True IsNew = False
							Entity AddContext597 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext598 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext599 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext599 ContextSwitchInterpreter
								if(AddContext599 != null)
								{
									System.Single OperandVar601 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop600 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar601 = prop600;
									AddContext599.Age = (System.Int32)( (OperandVar601));
								}
							}
							Named AddContext602 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext602 ContextSwitchInterpreter
								if(AddContext602 != null)
								{
									
									
									
									AddContext602.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar605 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar603 = default(System.String); //IsContext = False IsNew = False
									OperandVar603 = "human_name";
									System.String prop604 = External.RandomName( (OperandVar603)); //IsContext = False IsNew = False
									if(prop604 != null)
									{
										OperandVar605 = prop604;
									}
									AddContext602.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar605)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar607 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable606 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable606 != null)
						{
							OperandVar607 = StoredVariable606;
						}
						subContext593.Attach((Agent)( (OperandVar607)));
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
			
			System.Boolean OperandVar614 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable608 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable608 != null)
			{
				System.Boolean ifResult609; //IsContext = False IsNew = False
				System.Boolean OperandVar613 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar611 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable610 = ((Blackboards.event_marker)StoredVariable608.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable610 != null)
				{
					OperandVar611 = StoredVariable610;
				}
				System.Boolean prop612 = External.Has( (OperandVar611)); //IsContext = False IsNew = False
				OperandVar613 = prop612;
				if(ifResult609 = !(OperandVar613))
				{
					applicable = true;
					OperandVar614 = applicable;
				}
			}
			return (System.Boolean) (OperandVar614);
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
			Entity EntVar615 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar615 != null) EntVar615.ComponentAdded();
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
			
			System.Boolean OperandVar622 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable616 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable616 != null)
			{
				System.Boolean ifResult617; //IsContext = False IsNew = False
				System.Boolean OperandVar621 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar619 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable618 = ((Blackboards.personality)StoredVariable616.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable618 != null)
				{
					OperandVar619 = StoredVariable618;
				}
				System.Boolean prop620 = External.Has( (OperandVar619)); //IsContext = False IsNew = False
				OperandVar621 = prop620;
				if(ifResult617 = !(OperandVar621))
				{
					applicable = true;
					OperandVar622 = applicable;
				}
			}
			return (System.Boolean) (OperandVar622);
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
			Entity EntVar623 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar623 != null) EntVar623.ComponentAdded();
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
			
			System.Boolean OperandVar630 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable624 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable624 != null)
			{
				System.Boolean ifResult625; //IsContext = False IsNew = False
				System.Boolean OperandVar629 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar627 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable626 = ((Blackboards.aged_generation)StoredVariable624.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable626 != null)
				{
					OperandVar627 = StoredVariable626;
				}
				System.Boolean prop628 = External.Has( (OperandVar627)); //IsContext = False IsNew = False
				OperandVar629 = prop628;
				if(ifResult625 = !(OperandVar629))
				{
					applicable = true;
					OperandVar630 = applicable;
				}
			}
			return (System.Boolean) (OperandVar630);
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
			Entity EntVar631 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar631 != null) EntVar631.ComponentAdded();
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
			
			System.Boolean OperandVar641 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable632 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable632 != null)
			{
				Markers StoredVariable633 = ((Markers)StoredVariable632.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable633 != null)
				{
					System.Boolean ifResult634; //IsContext = False IsNew = False
					
					System.Boolean OperandVar637 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar635 = default(System.String); //IsContext = False IsNew = False
					OperandVar635 = "map_anchored";
					System.Boolean prop636 = StoredVariable633.HasMarker( (OperandVar635)); //IsContext = False IsNew = False
					OperandVar637 = prop636;
					
					System.Boolean OperandVar640 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar638 = default(System.String); //IsContext = False IsNew = False
					OperandVar638 = "history_place";
					System.Boolean prop639 = StoredVariable633.HasMarker( (OperandVar638)); //IsContext = False IsNew = False
					OperandVar640 = prop639;
					if(ifResult634 = ( (!(OperandVar637))) && ( ( (OperandVar640))))
					{
						applicable = true;
						OperandVar641 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar641);
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
				Markers subContext642 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext642 ContextSwitchInterpreter
				if(subContext642 != null)
				{
					System.String OperandVar643 = default(System.String); //IsContext = False IsNew = False
					OperandVar643 = "map_anchored";
					subContext642.SetUiMarker(( (OperandVar643)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar644 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar644 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar644)));
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
			
			System.Boolean OperandVar651 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable645 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable645 != null)
			{
				Markers StoredVariable646 = ((Markers)StoredVariable645.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable646 != null)
				{
					System.Boolean ifResult647; //IsContext = False IsNew = False
					System.Boolean OperandVar650 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar648 = default(System.String); //IsContext = False IsNew = False
					OperandVar648 = "encounter_ui_enlist";
					System.Boolean prop649 = StoredVariable646.HasMarker( (OperandVar648)); //IsContext = False IsNew = False
					OperandVar650 = prop649;
					if(ifResult647 = !(OperandVar650))
					{
						applicable = true;
						OperandVar651 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar651);
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
				Markers subContext652 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext652 ContextSwitchInterpreter
				if(subContext652 != null)
				{
					System.String OperandVar653 = default(System.String); //IsContext = False IsNew = False
					OperandVar653 = "encounter_ui_enlist";
					subContext652.SetUiMarker(( (OperandVar653)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar654 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar654 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar654)));
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
			
			System.Boolean OperandVar660 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable655 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable655 != null)
			{
				Named StoredVariable656 = ((Named)StoredVariable655.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable656 != null)
				{
					System.Boolean ifResult657; //IsContext = False IsNew = False
					
					System.Boolean OperandVar659 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable655 != null)
					{
						System.Boolean prop658 = StoredVariable655.Act; //IsContext = False IsNew = False
						OperandVar659 = prop658;
					}
					
					
					if(ifResult657 = ( ( (OperandVar659))) == ( ( (true))))
					{
						applicable = true;
						OperandVar660 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar660);
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
				UnityEngine.GameObject enc661 = enc; //IsContext = True IsNew = False
				Encounter AddContext662 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext662 ContextSwitchInterpreter
					if(AddContext662 != null)
					{
						UnityEngine.GameObject OperandVar663 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar663 = root;
						AddContext662.Context = (UnityEngine.GameObject)( (OperandVar663));
					}
				}
				Markers AddContext664 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext665 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext666 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext666 ContextSwitchInterpreter
					if(AddContext666 != null)
					{
						System.String OperandVar667 = default(System.String); //IsContext = False IsNew = False
						OperandVar667 = "main_name";
						
						
						AddContext666.Set(( (OperandVar667)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
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
			
			System.Boolean OperandVar681 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable668 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable668 != null)
			{
				Markers StoredVariable669 = ((Markers)StoredVariable668.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable669 != null)
				{
					System.Boolean ifResult670; //IsContext = False IsNew = False
					
					System.Boolean OperandVar677 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable668 != null)
					{
						UnityEngine.GameObject prop671 = StoredVariable668.ShowedObject; //IsContext = False IsNew = False
						if(prop671 != null)
						{
							System.Boolean ifResult672; //IsContext = False IsNew = False
							System.Boolean OperandVar676 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar674 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable673 = ((Place)prop671.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable673 != null)
							{
								OperandVar674 = StoredVariable673;
							}
							System.Boolean prop675 = External.Has( (OperandVar674)); //IsContext = False IsNew = False
							OperandVar676 = prop675;
							if(ifResult672 =  (OperandVar676))
							{
								OperandVar677 = ifResult672;
							}
						}
					}
					
					System.Boolean OperandVar680 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar678 = default(System.String); //IsContext = False IsNew = False
					OperandVar678 = "place_ui_cards_list";
					System.Boolean prop679 = StoredVariable669.HasMarker( (OperandVar678)); //IsContext = False IsNew = False
					OperandVar680 = prop679;
					if(ifResult670 = ( ( (OperandVar677))) && ( (!(OperandVar680))))
					{
						applicable = true;
						OperandVar681 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar681);
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
				Markers subContext682 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext682 ContextSwitchInterpreter
				if(subContext682 != null)
				{
					System.String OperandVar683 = default(System.String); //IsContext = False IsNew = False
					OperandVar683 = "place_ui_cards_list";
					subContext682.SetUiMarker(( (OperandVar683)).ToString());
				}
			}
			Place OperandVar687 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable684 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable684 != null)
			{
				UnityEngine.GameObject prop685 = StoredVariable684.ShowedObject; //IsContext = False IsNew = False
				if(prop685 != null)
				{
					Place StoredVariable686 = ((Place)prop685.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable686 != null)
					{
						OperandVar687 = StoredVariable686;
					}
				}
			}
			Place pl =  (OperandVar687); //IsContext = False IsNew = False
			System.String OperandVar688 = default(System.String); //IsContext = False IsNew = False
			OperandVar688 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx689 = External.SpawnPrefab(( (OperandVar688)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx689 ContextPropertySwitchInterpreter
				if(FuncCtx689 != null)
				{
					
					{
						AgentsUI subContext690 = (AgentsUI)FuncCtx689.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext690 ContextSwitchInterpreter
						if(subContext690 != null)
						{
							Place OperandVar691 = default(Place); //IsContext = False IsNew = False
							OperandVar691 = pl;
							subContext690.TargetPlace = (Place)( (OperandVar691));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext692 = (CardsHolderAgentsAdapter)FuncCtx689.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext692 ContextSwitchInterpreter
						if(subContext692 != null)
						{
							Place OperandVar693 = default(Place); //IsContext = False IsNew = False
							OperandVar693 = pl;
							subContext692.TargetPlace = (Place)( (OperandVar693));
						}
					}
					UnityEngine.GameObject OperandVar694 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar694 = FuncCtx689;
					UnityEngine.GameObject OperandVar695 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar695 = root;
					External.SetParent((UnityEngine.GameObject)( (OperandVar694)),(UnityEngine.GameObject)( (OperandVar695)));
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
			
			System.Boolean OperandVar701 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable696 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable696 != null)
			{
				System.Boolean ifResult697; //IsContext = False IsNew = False
				System.Boolean OperandVar700 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop698 = StoredVariable696.ShowedObject; //IsContext = False IsNew = False
				if(prop698 != null)
				{
					Place StoredVariable699 = ((Place)prop698.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable699 != null)
					{
						applicable = true;
						OperandVar700 = applicable;
					}
				}
				if(ifResult697 =  (OperandVar700))
				{
					applicable = true;
					OperandVar701 = applicable;
				}
			}
			return (System.Boolean) (OperandVar701);
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
			
			TextField ContextVar702 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement TextField ContextVar702 ContextSwitchInterpreter
				if(ContextVar702 != null)
				{
					
					ContextVar702.Label = (System.String)( ("size"));
					System.Int32 OperandVar707 = default(System.Int32); //IsContext = False IsNew = False
					UiObject StoredVariable703 = ((UiObject)ContextVar702.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
					if(StoredVariable703 != null)
					{
						UnityEngine.GameObject prop704 = StoredVariable703.ShowedObject; //IsContext = False IsNew = False
						if(prop704 != null)
						{
							Place StoredVariable705 = ((Place)prop704.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable705 != null)
							{
								System.Int32 prop706 = StoredVariable705.Size; //IsContext = False IsNew = False
								OperandVar707 = prop706;
							}
						}
					}
					ContextVar702.Show(( (OperandVar707)).ToString());
					
					{
						UnityEngine.UI.LayoutElement subContext708 = ContextVar702.Layout; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.UI.LayoutElement subContext708 ContextPropertySwitchInterpreter
						if(subContext708 != null)
						{
							
							subContext708.minHeight = (System.Single)( (20f));
						}
					}
				}
			}
			Entity EntVar709 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar709 != null) EntVar709.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class brave_war_act : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar720 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable710 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable710 != null)
			{
				Blackboards.ruler_role StoredVariable711 = ((Blackboards.ruler_role)StoredVariable710.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable711 != null)
				{
					Blackboards.personality StoredVariable712 = ((Blackboards.personality)StoredVariable711.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
					if(StoredVariable712 != null)
					{
						System.Boolean ifResult713; //IsContext = False IsNew = False
						
						System.Boolean OperandVar715 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable710 != null)
						{
							System.Boolean prop714 = StoredVariable710.IsActive; //IsContext = False IsNew = False
							OperandVar715 = prop714;
						}
						
						System.Boolean OperandVar719 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar717 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable711 != null)
						{
							UnityEngine.GameObject prop716 = StoredVariable711.CurrentCampaign; //IsContext = False IsNew = False
							if(prop716 != null)
							{
								OperandVar717 = prop716;
							}
						}
						System.Boolean prop718 = External.Has( (OperandVar717)); //IsContext = False IsNew = False
						OperandVar719 = prop718;
						if(ifResult713 = ( ( (OperandVar715))) && ( ( (OperandVar719))))
						{
							applicable = true;
							OperandVar720 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar720);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar723 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable721 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable721 != null)
			{
				System.Single prop722 = StoredVariable721.Brave; //IsContext = False IsNew = False
				OperandVar723 = prop722;
			}
			return (System.Single) (OperandVar723);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject brave_war_act = new UnityEngine.GameObject("brave_war_act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject brave_war_act724 = brave_war_act; //IsContext = True IsNew = False
				Event AddContext725 = (Event)brave_war_act.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext725 ContextSwitchInterpreter
					if(AddContext725 != null)
					{
						UnityEngine.GameObject OperandVar726 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar726 = root;
						AddContext725.Context = (UnityEngine.GameObject)( (OperandVar726));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(brave_war_act, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class rational_war_act : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar737 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable727 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable727 != null)
			{
				Blackboards.ruler_role StoredVariable728 = ((Blackboards.ruler_role)StoredVariable727.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable728 != null)
				{
					Blackboards.personality StoredVariable729 = ((Blackboards.personality)StoredVariable728.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
					if(StoredVariable729 != null)
					{
						System.Boolean ifResult730; //IsContext = False IsNew = False
						
						System.Boolean OperandVar732 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable727 != null)
						{
							System.Boolean prop731 = StoredVariable727.IsActive; //IsContext = False IsNew = False
							OperandVar732 = prop731;
						}
						
						System.Boolean OperandVar736 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar734 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable728 != null)
						{
							UnityEngine.GameObject prop733 = StoredVariable728.CurrentCampaign; //IsContext = False IsNew = False
							if(prop733 != null)
							{
								OperandVar734 = prop733;
							}
						}
						System.Boolean prop735 = External.Has( (OperandVar734)); //IsContext = False IsNew = False
						OperandVar736 = prop735;
						if(ifResult730 = ( ( (OperandVar732))) && ( ( (OperandVar736))))
						{
							applicable = true;
							OperandVar737 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar737);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar740 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable738 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable738 != null)
			{
				System.Single prop739 = StoredVariable738.Rational; //IsContext = False IsNew = False
				OperandVar740 = prop739;
			}
			return (System.Single) (OperandVar740);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject rational_war_act = new UnityEngine.GameObject("rational_war_act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject rational_war_act741 = rational_war_act; //IsContext = True IsNew = False
				Event AddContext742 = (Event)rational_war_act.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext742 ContextSwitchInterpreter
					if(AddContext742 != null)
					{
						UnityEngine.GameObject OperandVar743 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar743 = root;
						AddContext742.Context = (UnityEngine.GameObject)( (OperandVar743));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(rational_war_act, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class optimistic_war_act : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar754 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable744 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable744 != null)
			{
				Blackboards.ruler_role StoredVariable745 = ((Blackboards.ruler_role)StoredVariable744.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable745 != null)
				{
					Blackboards.personality StoredVariable746 = ((Blackboards.personality)StoredVariable745.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
					if(StoredVariable746 != null)
					{
						System.Boolean ifResult747; //IsContext = False IsNew = False
						
						System.Boolean OperandVar749 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable744 != null)
						{
							System.Boolean prop748 = StoredVariable744.IsActive; //IsContext = False IsNew = False
							OperandVar749 = prop748;
						}
						
						System.Boolean OperandVar753 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar751 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable745 != null)
						{
							UnityEngine.GameObject prop750 = StoredVariable745.CurrentCampaign; //IsContext = False IsNew = False
							if(prop750 != null)
							{
								OperandVar751 = prop750;
							}
						}
						System.Boolean prop752 = External.Has( (OperandVar751)); //IsContext = False IsNew = False
						OperandVar753 = prop752;
						if(ifResult747 = ( ( (OperandVar749))) && ( ( (OperandVar753))))
						{
							applicable = true;
							OperandVar754 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar754);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar757 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable755 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable755 != null)
			{
				System.Single prop756 = StoredVariable755.Optimistic; //IsContext = False IsNew = False
				OperandVar757 = prop756;
			}
			return (System.Single) (OperandVar757);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject optimistic_war_act = new UnityEngine.GameObject("optimistic_war_act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject optimistic_war_act758 = optimistic_war_act; //IsContext = True IsNew = False
				Event AddContext759 = (Event)optimistic_war_act.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext759 ContextSwitchInterpreter
					if(AddContext759 != null)
					{
						UnityEngine.GameObject OperandVar760 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar760 = root;
						AddContext759.Context = (UnityEngine.GameObject)( (OperandVar760));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(optimistic_war_act, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class cruel_war_act : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar771 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable761 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable761 != null)
			{
				Blackboards.ruler_role StoredVariable762 = ((Blackboards.ruler_role)StoredVariable761.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable762 != null)
				{
					Blackboards.personality StoredVariable763 = ((Blackboards.personality)StoredVariable762.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
					if(StoredVariable763 != null)
					{
						System.Boolean ifResult764; //IsContext = False IsNew = False
						
						System.Boolean OperandVar766 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable761 != null)
						{
							System.Boolean prop765 = StoredVariable761.IsActive; //IsContext = False IsNew = False
							OperandVar766 = prop765;
						}
						
						System.Boolean OperandVar770 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar768 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable762 != null)
						{
							UnityEngine.GameObject prop767 = StoredVariable762.CurrentCampaign; //IsContext = False IsNew = False
							if(prop767 != null)
							{
								OperandVar768 = prop767;
							}
						}
						System.Boolean prop769 = External.Has( (OperandVar768)); //IsContext = False IsNew = False
						OperandVar770 = prop769;
						if(ifResult764 = ( ( (OperandVar766))) && ( ( (OperandVar770))))
						{
							applicable = true;
							OperandVar771 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar771);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar774 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable772 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable772 != null)
			{
				System.Single prop773 = StoredVariable772.Cruel; //IsContext = False IsNew = False
				OperandVar774 = prop773;
			}
			return (System.Single) (OperandVar774);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject cruel_war_act = new UnityEngine.GameObject("cruel_war_act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cruel_war_act775 = cruel_war_act; //IsContext = True IsNew = False
				Event AddContext776 = (Event)cruel_war_act.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext776 ContextSwitchInterpreter
					if(AddContext776 != null)
					{
						UnityEngine.GameObject OperandVar777 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar777 = root;
						AddContext776.Context = (UnityEngine.GameObject)( (OperandVar777));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cruel_war_act, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class ambitious_war_act : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar788 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable778 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable778 != null)
			{
				Blackboards.ruler_role StoredVariable779 = ((Blackboards.ruler_role)StoredVariable778.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable779 != null)
				{
					Blackboards.personality StoredVariable780 = ((Blackboards.personality)StoredVariable779.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
					if(StoredVariable780 != null)
					{
						System.Boolean ifResult781; //IsContext = False IsNew = False
						
						System.Boolean OperandVar783 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable778 != null)
						{
							System.Boolean prop782 = StoredVariable778.IsActive; //IsContext = False IsNew = False
							OperandVar783 = prop782;
						}
						
						System.Boolean OperandVar787 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar785 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable779 != null)
						{
							UnityEngine.GameObject prop784 = StoredVariable779.CurrentCampaign; //IsContext = False IsNew = False
							if(prop784 != null)
							{
								OperandVar785 = prop784;
							}
						}
						System.Boolean prop786 = External.Has( (OperandVar785)); //IsContext = False IsNew = False
						OperandVar787 = prop786;
						if(ifResult781 = ( ( (OperandVar783))) && ( ( (OperandVar787))))
						{
							applicable = true;
							OperandVar788 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar788);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar791 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable789 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable789 != null)
			{
				System.Single prop790 = StoredVariable789.Ambitious; //IsContext = False IsNew = False
				OperandVar791 = prop790;
			}
			return (System.Single) (OperandVar791);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ambitious_war_act = new UnityEngine.GameObject("ambitious_war_act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ambitious_war_act792 = ambitious_war_act; //IsContext = True IsNew = False
				Event AddContext793 = (Event)ambitious_war_act.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext793 ContextSwitchInterpreter
					if(AddContext793 != null)
					{
						UnityEngine.GameObject OperandVar794 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar794 = root;
						AddContext793.Context = (UnityEngine.GameObject)( (OperandVar794));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ambitious_war_act, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class reckless_war_act : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar805 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable795 = ((Actor)root.GetComponent(typeof(Actor))); //IsContext = False IsNew = False
			if(StoredVariable795 != null)
			{
				Blackboards.ruler_role StoredVariable796 = ((Blackboards.ruler_role)StoredVariable795.GetComponent(typeof(Blackboards.ruler_role))); //IsContext = False IsNew = False
				if(StoredVariable796 != null)
				{
					Blackboards.personality StoredVariable797 = ((Blackboards.personality)StoredVariable796.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
					if(StoredVariable797 != null)
					{
						System.Boolean ifResult798; //IsContext = False IsNew = False
						
						System.Boolean OperandVar800 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable795 != null)
						{
							System.Boolean prop799 = StoredVariable795.IsActive; //IsContext = False IsNew = False
							OperandVar800 = prop799;
						}
						
						System.Boolean OperandVar804 = default(System.Boolean); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar802 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						if(StoredVariable796 != null)
						{
							UnityEngine.GameObject prop801 = StoredVariable796.CurrentCampaign; //IsContext = False IsNew = False
							if(prop801 != null)
							{
								OperandVar802 = prop801;
							}
						}
						System.Boolean prop803 = External.Has( (OperandVar802)); //IsContext = False IsNew = False
						OperandVar804 = prop803;
						if(ifResult798 = ( ( (OperandVar800))) && ( ( (OperandVar804))))
						{
							applicable = true;
							OperandVar805 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar805);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar808 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable806 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable806 != null)
			{
				System.Single prop807 = StoredVariable806.Reckless; //IsContext = False IsNew = False
				OperandVar808 = prop807;
			}
			return (System.Single) (OperandVar808);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject reckless_war_act = new UnityEngine.GameObject("reckless_war_act"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject reckless_war_act809 = reckless_war_act; //IsContext = True IsNew = False
				Event AddContext810 = (Event)reckless_war_act.AddComponent(typeof(Event)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Event AddContext810 ContextSwitchInterpreter
					if(AddContext810 != null)
					{
						UnityEngine.GameObject OperandVar811 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar811 = root;
						AddContext810.Context = (UnityEngine.GameObject)( (OperandVar811));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(reckless_war_act, 0.1f);
		}
        }
    }
}
