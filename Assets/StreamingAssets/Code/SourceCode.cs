namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_agents : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar1 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable0 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				applicable = true;
				OperandVar1 = applicable;
			}
			return (System.Boolean) (OperandVar1);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class country_cities : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar7 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable2 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable2 != null)
			{
				System.Boolean ifResult3; //IsContext = False IsNew = False
				System.Boolean OperandVar6 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar4 = default(System.String); //IsContext = False IsNew = False
				OperandVar4 = "country_node";
				System.Boolean prop5 = StoredVariable2.HasMarker( (OperandVar4)); //IsContext = False IsNew = False
				OperandVar6 = prop5;
				if(ifResult3 =  (OperandVar6))
				{
					applicable = true;
					OperandVar7 = applicable;
				}
			}
			return (System.Boolean) (OperandVar7);
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
			
			root.AddComponent<Blackboards.country>();
			Entity EntVar8 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar8 != null) EntVar8.ComponentAdded();
			System.Single OperandVar10 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop9 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
			OperandVar10 = prop9;
			for (int i = 0; i <  (OperandVar10); i++)
			{
				UnityEngine.GameObject city_obj = new UnityEngine.GameObject("city_obj"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject city_obj11 = city_obj; //IsContext = True IsNew = False
					Entity AddContext12 = (Entity)city_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Entity AddContext12 ContextSwitchInterpreter
						if(AddContext12 != null)
						{
							UnityEngine.Vector3 OperandVar18 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
							System.Single OperandVar14 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop13 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar14 = prop13;
							System.Single OperandVar16 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop15 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar16 = prop15;
							UnityEngine.Vector3 prop17 = External.Vec( (OperandVar14), (OperandVar16)); //IsContext = False IsNew = False
							OperandVar18 = prop17;
							AddContext12.Position = (UnityEngine.Vector3)( (OperandVar18));
						}
					}
					Place AddContext19 = (Place)city_obj.AddComponent(typeof(Place)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Place AddContext19 ContextSwitchInterpreter
						if(AddContext19 != null)
						{
							
							AddContext19.Size = (System.Int32)( (100f));
						}
					}
					Named AddContext20 = (Named)city_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Named AddContext20 ContextSwitchInterpreter
						if(AddContext20 != null)
						{
							System.String OperandVar21 = default(System.String); //IsContext = False IsNew = False
							OperandVar21 = "main_name";
							
							System.String OperandVar24 = default(System.String); //IsContext = False IsNew = False
							System.String OperandVar22 = default(System.String); //IsContext = False IsNew = False
							OperandVar22 = "country_name";
							System.String prop23 = External.RandomName( (OperandVar22)); //IsContext = False IsNew = False
							if(prop23 != null)
							{
								OperandVar24 = prop23;
							}
							AddContext20.Set(( (OperandVar21)).ToString(),(System.Single)( (0f)),( (OperandVar24)).ToString());
						}
					}
					Interactables AddContext25 = (Interactables)city_obj.AddComponent(typeof(Interactables)); //IsContext = True IsNew = True
					Interactable AddContext26 = (Interactable)city_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
					Blackboards.city AddContext27 = (Blackboards.city)city_obj.AddComponent(typeof(Blackboards.city)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.city AddContext27 ContextSwitchInterpreter
						if(AddContext27 != null)
						{
							System.Single OperandVar29 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop28 = External.Random( (3f), (6f)); //IsContext = False IsNew = False
							OperandVar29 = prop28;
							AddContext27.Size = (System.Int32)( (OperandVar29));
							UnityEngine.GameObject OperandVar30 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar30 = root;
							AddContext27.Of = (UnityEngine.GameObject)( (OperandVar30));
						}
					}
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(city_obj, 0.1f);
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_cultist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable31 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				applicable = true;
				OperandVar32 = applicable;
			}
			return (System.Boolean) (OperandVar32);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class temp_enc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar34 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable33 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable33 != null)
			{
				applicable = true;
				OperandVar34 = applicable;
			}
			return (System.Boolean) (OperandVar34);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class common_noble : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar42 = default(System.Boolean); //IsContext = False IsNew = False
			Interactables StoredVariable35 = ((Interactables)root.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
			if(StoredVariable35 != null)
			{
				Blackboards.city StoredVariable36 = ((Blackboards.city)StoredVariable35.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
				if(StoredVariable36 != null)
				{
					System.Boolean ifResult37; //IsContext = False IsNew = False
					
					System.Int32 OperandVar39 = default(System.Int32); //IsContext = False IsNew = False
					if(StoredVariable35 != null)
					{
						System.Int32 prop38 = StoredVariable35.Count; //IsContext = False IsNew = False
						OperandVar39 = prop38;
					}
					
					System.Int32 OperandVar41 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop40 = StoredVariable36.Size; //IsContext = False IsNew = False
					OperandVar41 = prop40;
					if(ifResult37 = ( ( (OperandVar39))) < ( ( (OperandVar41))))
					{
						applicable = true;
						OperandVar42 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar42);
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
			
			UnityEngine.GameObject noble_obj = new UnityEngine.GameObject("noble_obj"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject noble_obj43 = noble_obj; //IsContext = True IsNew = False
				Actor AddContext44 = (Actor)noble_obj.AddComponent(typeof(Actor)); //IsContext = True IsNew = True
				Entity AddContext45 = (Entity)noble_obj.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext46 = (Markers)noble_obj.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Blackboards.personality AddContext47 = (Blackboards.personality)noble_obj.AddComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = True
				Interactable AddContext48 = (Interactable)noble_obj.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
				Blackboards.noble AddContext49 = (Blackboards.noble)noble_obj.AddComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.noble AddContext49 ContextSwitchInterpreter
					if(AddContext49 != null)
					{
						UnityEngine.GameObject OperandVar52 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.city StoredVariable50 = ((Blackboards.city)root.GetComponent(typeof(Blackboards.city))); //IsContext = False IsNew = False
						if(StoredVariable50 != null)
						{
							UnityEngine.GameObject prop51 = StoredVariable50.Of; //IsContext = False IsNew = False
							if(prop51 != null)
							{
								OperandVar52 = prop51;
							}
						}
						AddContext49.Of = (UnityEngine.GameObject)( (OperandVar52));
					}
				}
				Named AddContext53 = (Named)noble_obj.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext53 ContextSwitchInterpreter
					if(AddContext53 != null)
					{
						System.String OperandVar54 = default(System.String); //IsContext = False IsNew = False
						OperandVar54 = "main_name";
						
						System.String OperandVar57 = default(System.String); //IsContext = False IsNew = False
						System.String OperandVar55 = default(System.String); //IsContext = False IsNew = False
						OperandVar55 = "human_name";
						System.String prop56 = External.RandomName( (OperandVar55)); //IsContext = False IsNew = False
						if(prop56 != null)
						{
							OperandVar57 = prop56;
						}
						AddContext53.Set(( (OperandVar54)).ToString(),(System.Single)( (0f)),( (OperandVar57)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(noble_obj, 0.1f);
			
			{
				Interactables subContext58 = (Interactables)root.GetComponent(typeof(Interactables)); //IsContext = True IsNew = False
				//ContextStatement Interactables subContext58 ContextSwitchInterpreter
				if(subContext58 != null)
				{
					UnityEngine.GameObject OperandVar59 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar59 = noble_obj;
					subContext58.Attach((UnityEngine.GameObject)( (OperandVar59)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_emperor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar74 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable60 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable60 != null)
			{
				Named StoredVariable61 = ((Named)StoredVariable60.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable61 != null)
				{
					System.Boolean ifResult62; //IsContext = False IsNew = False
					
					Blackboards.country OperandVar65 = default(Blackboards.country); //IsContext = False IsNew = False
					if(StoredVariable60 != null)
					{
						UnityEngine.GameObject prop63 = StoredVariable60.Of; //IsContext = False IsNew = False
						if(prop63 != null)
						{
							Blackboards.country StoredVariable64 = ((Blackboards.country)prop63.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable64 != null)
							{
								OperandVar65 = StoredVariable64;
							}
						}
					}
					
					System.Boolean OperandVar73 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable60 != null)
					{
						UnityEngine.GameObject prop66 = StoredVariable60.Of; //IsContext = False IsNew = False
						if(prop66 != null)
						{
							Blackboards.country StoredVariable67 = ((Blackboards.country)prop66.GetComponent(typeof(Blackboards.country))); //IsContext = False IsNew = False
							if(StoredVariable67 != null)
							{
								System.Boolean ifResult68; //IsContext = False IsNew = False
								System.Boolean OperandVar72 = default(System.Boolean); //IsContext = False IsNew = False
								UnityEngine.GameObject OperandVar70 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								UnityEngine.GameObject prop69 = StoredVariable67.Emperor; //IsContext = False IsNew = False
								if(prop69 != null)
								{
									OperandVar70 = prop69;
								}
								System.Boolean prop71 = External.Has( (OperandVar70)); //IsContext = False IsNew = False
								OperandVar72 = prop71;
								if(ifResult68 = !(OperandVar72))
								{
									OperandVar73 = ifResult68;
								}
							}
						}
					}
					if(ifResult62 = ( ( (OperandVar65))) && ( ( (OperandVar73))))
					{
						applicable = true;
						OperandVar74 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar74);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (10f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext75 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext75 ContextSwitchInterpreter
				if(subContext75 != null)
				{
					System.String OperandVar76 = default(System.String); //IsContext = False IsNew = False
					OperandVar76 = "postfix";
					
					
					subContext75.Set(( (OperandVar76)).ToString(),(System.Single)( (1f)),( (", the Emperor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext77 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext77 ContextSwitchInterpreter
				if(subContext77 != null)
				{
					System.Single OperandVar79 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop78 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar79 = prop78;
					subContext77.Loyalty = (System.Single)( (OperandVar79));
					System.Single OperandVar81 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop80 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar81 = prop80;
					subContext77.Sanity = (System.Single)( (OperandVar81));
					System.Single OperandVar83 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop82 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar83 = prop82;
					subContext77.Influence = (System.Single)( (OperandVar83));
					System.Single OperandVar85 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop84 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar85 = prop84;
					subContext77.Knowledge = (System.Single)( (OperandVar85));
					System.Single OperandVar87 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop86 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar87 = prop86;
					subContext77.Occult = (System.Single)( (OperandVar87));
				}
			}
			
			{
				Blackboards.noble subContext88 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext88 ContextSwitchInterpreter
				if(subContext88 != null)
				{
					
					{
						UnityEngine.GameObject subContext89 = subContext88.Of; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext89 ContextPropertySwitchInterpreter
						if(subContext89 != null)
						{
							
							{
								Blackboards.country subContext90 = (Blackboards.country)subContext89.GetComponent(typeof(Blackboards.country)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.country subContext90 ContextSwitchInterpreter
								if(subContext90 != null)
								{
									UnityEngine.GameObject OperandVar91 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
									OperandVar91 = root;
									subContext90.Emperor = (UnityEngine.GameObject)( (OperandVar91));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_inquisitor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar94 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable92 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable92 != null)
			{
				Named StoredVariable93 = ((Named)StoredVariable92.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable93 != null)
				{
					applicable = true;
					OperandVar94 = applicable;
				}
			}
			return (System.Boolean) (OperandVar94);
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
				Named subContext95 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext95 ContextSwitchInterpreter
				if(subContext95 != null)
				{
					System.String OperandVar96 = default(System.String); //IsContext = False IsNew = False
					OperandVar96 = "postfix";
					
					
					subContext95.Set(( (OperandVar96)).ToString(),(System.Single)( (1f)),( (", an inquisitor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext97 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext97 ContextSwitchInterpreter
				if(subContext97 != null)
				{
					System.Single OperandVar99 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop98 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar99 = prop98;
					subContext97.Loyalty = (System.Single)( (OperandVar99));
					System.Single OperandVar101 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop100 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar101 = prop100;
					subContext97.Sanity = (System.Single)( (OperandVar101));
					System.Single OperandVar103 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop102 = External.Random( (0.8f), (1f)); //IsContext = False IsNew = False
					OperandVar103 = prop102;
					subContext97.Influence = (System.Single)( (OperandVar103));
					System.Single OperandVar105 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop104 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar105 = prop104;
					subContext97.Knowledge = (System.Single)( (OperandVar105));
					System.Single OperandVar107 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop106 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar107 = prop106;
					subContext97.Occult = (System.Single)( (OperandVar107));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_trader : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar110 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable108 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable108 != null)
			{
				Named StoredVariable109 = ((Named)StoredVariable108.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable109 != null)
				{
					applicable = true;
					OperandVar110 = applicable;
				}
			}
			return (System.Boolean) (OperandVar110);
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
				Named subContext111 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext111 ContextSwitchInterpreter
				if(subContext111 != null)
				{
					System.String OperandVar112 = default(System.String); //IsContext = False IsNew = False
					OperandVar112 = "postfix";
					
					
					subContext111.Set(( (OperandVar112)).ToString(),(System.Single)( (1f)),( (", a trader")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext113 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext113 ContextSwitchInterpreter
				if(subContext113 != null)
				{
					System.Single OperandVar115 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop114 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar115 = prop114;
					subContext113.Loyalty = (System.Single)( (OperandVar115));
					System.Single OperandVar117 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop116 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar117 = prop116;
					subContext113.Sanity = (System.Single)( (OperandVar117));
					System.Single OperandVar119 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop118 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar119 = prop118;
					subContext113.Influence = (System.Single)( (OperandVar119));
					System.Single OperandVar121 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop120 = External.Random( (0.4f), (0.5f)); //IsContext = False IsNew = False
					OperandVar121 = prop120;
					subContext113.Knowledge = (System.Single)( (OperandVar121));
					System.Single OperandVar123 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop122 = External.Random( (0.1f), (0.3f)); //IsContext = False IsNew = False
					OperandVar123 = prop122;
					subContext113.Occult = (System.Single)( (OperandVar123));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_aristocrat : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar126 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable124 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable124 != null)
			{
				Named StoredVariable125 = ((Named)StoredVariable124.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable125 != null)
				{
					applicable = true;
					OperandVar126 = applicable;
				}
			}
			return (System.Boolean) (OperandVar126);
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
				Named subContext127 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext127 ContextSwitchInterpreter
				if(subContext127 != null)
				{
					System.String OperandVar128 = default(System.String); //IsContext = False IsNew = False
					OperandVar128 = "postfix";
					
					
					subContext127.Set(( (OperandVar128)).ToString(),(System.Single)( (1f)),( (", an aristocrat")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext129 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext129 ContextSwitchInterpreter
				if(subContext129 != null)
				{
					System.Single OperandVar131 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop130 = External.Random( (0.5f), (0.6f)); //IsContext = False IsNew = False
					OperandVar131 = prop130;
					subContext129.Loyalty = (System.Single)( (OperandVar131));
					System.Single OperandVar133 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop132 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar133 = prop132;
					subContext129.Sanity = (System.Single)( (OperandVar133));
					System.Single OperandVar135 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop134 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar135 = prop134;
					subContext129.Influence = (System.Single)( (OperandVar135));
					System.Single OperandVar137 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop136 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar137 = prop136;
					subContext129.Knowledge = (System.Single)( (OperandVar137));
					System.Single OperandVar139 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop138 = External.Random( (0.1f), (1f)); //IsContext = False IsNew = False
					OperandVar139 = prop138;
					subContext129.Occult = (System.Single)( (OperandVar139));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_governor : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar142 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable140 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable140 != null)
			{
				Named StoredVariable141 = ((Named)StoredVariable140.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable141 != null)
				{
					applicable = true;
					OperandVar142 = applicable;
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
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext143 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext143 ContextSwitchInterpreter
				if(subContext143 != null)
				{
					System.String OperandVar144 = default(System.String); //IsContext = False IsNew = False
					OperandVar144 = "postfix";
					
					
					subContext143.Set(( (OperandVar144)).ToString(),(System.Single)( (1f)),( (", a governor")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext145 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext145 ContextSwitchInterpreter
				if(subContext145 != null)
				{
					System.Single OperandVar147 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop146 = External.Random( (0.2f), (0.6f)); //IsContext = False IsNew = False
					OperandVar147 = prop146;
					subContext145.Loyalty = (System.Single)( (OperandVar147));
					System.Single OperandVar149 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop148 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar149 = prop148;
					subContext145.Sanity = (System.Single)( (OperandVar149));
					System.Single OperandVar151 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop150 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar151 = prop150;
					subContext145.Influence = (System.Single)( (OperandVar151));
					System.Single OperandVar153 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop152 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar153 = prop152;
					subContext145.Knowledge = (System.Single)( (OperandVar153));
					System.Single OperandVar155 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop154 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar155 = prop154;
					subContext145.Occult = (System.Single)( (OperandVar155));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_general : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar158 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable156 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable156 != null)
			{
				Named StoredVariable157 = ((Named)StoredVariable156.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable157 != null)
				{
					applicable = true;
					OperandVar158 = applicable;
				}
			}
			return (System.Boolean) (OperandVar158);
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
				Named subContext159 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext159 ContextSwitchInterpreter
				if(subContext159 != null)
				{
					System.String OperandVar160 = default(System.String); //IsContext = False IsNew = False
					OperandVar160 = "postfix";
					
					
					subContext159.Set(( (OperandVar160)).ToString(),(System.Single)( (1f)),( (", a general")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext161 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext161 ContextSwitchInterpreter
				if(subContext161 != null)
				{
					System.Single OperandVar163 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop162 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar163 = prop162;
					subContext161.Loyalty = (System.Single)( (OperandVar163));
					System.Single OperandVar165 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop164 = External.Random( (0.7f), (1f)); //IsContext = False IsNew = False
					OperandVar165 = prop164;
					subContext161.Sanity = (System.Single)( (OperandVar165));
					System.Single OperandVar167 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop166 = External.Random( (0.3f), (0.4f)); //IsContext = False IsNew = False
					OperandVar167 = prop166;
					subContext161.Influence = (System.Single)( (OperandVar167));
					System.Single OperandVar169 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop168 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar169 = prop168;
					subContext161.Knowledge = (System.Single)( (OperandVar169));
					System.Single OperandVar171 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop170 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar171 = prop170;
					subContext161.Occult = (System.Single)( (OperandVar171));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_alchemist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar174 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable172 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable172 != null)
			{
				Named StoredVariable173 = ((Named)StoredVariable172.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable173 != null)
				{
					applicable = true;
					OperandVar174 = applicable;
				}
			}
			return (System.Boolean) (OperandVar174);
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
				Named subContext175 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext175 ContextSwitchInterpreter
				if(subContext175 != null)
				{
					System.String OperandVar176 = default(System.String); //IsContext = False IsNew = False
					OperandVar176 = "postfix";
					
					
					subContext175.Set(( (OperandVar176)).ToString(),(System.Single)( (1f)),( (", an alchemist")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext177 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext177 ContextSwitchInterpreter
				if(subContext177 != null)
				{
					System.Single OperandVar179 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop178 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar179 = prop178;
					subContext177.Loyalty = (System.Single)( (OperandVar179));
					System.Single OperandVar181 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop180 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar181 = prop180;
					subContext177.Sanity = (System.Single)( (OperandVar181));
					System.Single OperandVar183 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop182 = External.Random( (0f), (0.1f)); //IsContext = False IsNew = False
					OperandVar183 = prop182;
					subContext177.Influence = (System.Single)( (OperandVar183));
					System.Single OperandVar185 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop184 = External.Random( (0.3f), (1f)); //IsContext = False IsNew = False
					OperandVar185 = prop184;
					subContext177.Knowledge = (System.Single)( (OperandVar185));
					System.Single OperandVar187 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop186 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar187 = prop186;
					subContext177.Occult = (System.Single)( (OperandVar187));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_mage : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable188 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable188 != null)
			{
				Named StoredVariable189 = ((Named)StoredVariable188.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable189 != null)
				{
					applicable = true;
					OperandVar190 = applicable;
				}
			}
			return (System.Boolean) (OperandVar190);
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
				Named subContext191 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext191 ContextSwitchInterpreter
				if(subContext191 != null)
				{
					System.String OperandVar192 = default(System.String); //IsContext = False IsNew = False
					OperandVar192 = "postfix";
					
					
					subContext191.Set(( (OperandVar192)).ToString(),(System.Single)( (1f)),( (", a mage")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext193 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext193 ContextSwitchInterpreter
				if(subContext193 != null)
				{
					System.Single OperandVar195 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop194 = External.Random( (0f), (0.2f)); //IsContext = False IsNew = False
					OperandVar195 = prop194;
					subContext193.Loyalty = (System.Single)( (OperandVar195));
					System.Single OperandVar197 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop196 = External.Random( (0f), (0.3f)); //IsContext = False IsNew = False
					OperandVar197 = prop196;
					subContext193.Sanity = (System.Single)( (OperandVar197));
					System.Single OperandVar199 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop198 = External.Random( (0f), (0.5f)); //IsContext = False IsNew = False
					OperandVar199 = prop198;
					subContext193.Influence = (System.Single)( (OperandVar199));
					System.Single OperandVar201 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop200 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar201 = prop200;
					subContext193.Knowledge = (System.Single)( (OperandVar201));
					System.Single OperandVar203 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop202 = External.Random( (0.3f), (0.6f)); //IsContext = False IsNew = False
					OperandVar203 = prop202;
					subContext193.Occult = (System.Single)( (OperandVar203));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="noble_decomposition", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=true)]
    public class noble_is_priest : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar206 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.noble StoredVariable204 = ((Blackboards.noble)root.GetComponent(typeof(Blackboards.noble))); //IsContext = False IsNew = False
			if(StoredVariable204 != null)
			{
				Named StoredVariable205 = ((Named)StoredVariable204.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable205 != null)
				{
					applicable = true;
					OperandVar206 = applicable;
				}
			}
			return (System.Boolean) (OperandVar206);
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
				Named subContext207 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext207 ContextSwitchInterpreter
				if(subContext207 != null)
				{
					System.String OperandVar208 = default(System.String); //IsContext = False IsNew = False
					OperandVar208 = "postfix";
					
					
					subContext207.Set(( (OperandVar208)).ToString(),(System.Single)( (1f)),( (", a priest")).ToString());
				}
			}
			
			{
				Blackboards.noble subContext209 = (Blackboards.noble)root.GetComponent(typeof(Blackboards.noble)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.noble subContext209 ContextSwitchInterpreter
				if(subContext209 != null)
				{
					System.Single OperandVar211 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop210 = External.Random( (0.9f), (1f)); //IsContext = False IsNew = False
					OperandVar211 = prop210;
					subContext209.Loyalty = (System.Single)( (OperandVar211));
					System.Single OperandVar213 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop212 = External.Random( (0.6f), (1f)); //IsContext = False IsNew = False
					OperandVar213 = prop212;
					subContext209.Sanity = (System.Single)( (OperandVar213));
					System.Single OperandVar215 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop214 = External.Random( (0.6f), (0.8f)); //IsContext = False IsNew = False
					OperandVar215 = prop214;
					subContext209.Influence = (System.Single)( (OperandVar215));
					System.Single OperandVar217 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop216 = External.Random( (0.5f), (1f)); //IsContext = False IsNew = False
					OperandVar217 = prop216;
					subContext209.Knowledge = (System.Single)( (OperandVar217));
					System.Single OperandVar219 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop218 = External.Random( (0f), (0f)); //IsContext = False IsNew = False
					OperandVar219 = prop218;
					subContext209.Occult = (System.Single)( (OperandVar219));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class aged_person : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar226 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable220 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable220 != null)
			{
				System.Boolean ifResult221; //IsContext = False IsNew = False
				System.Boolean OperandVar225 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged OperandVar223 = default(Blackboards.aged); //IsContext = False IsNew = False
				Blackboards.aged StoredVariable222 = ((Blackboards.aged)StoredVariable220.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
				if(StoredVariable222 != null)
				{
					OperandVar223 = StoredVariable222;
				}
				System.Boolean prop224 = External.Has( (OperandVar223)); //IsContext = False IsNew = False
				OperandVar225 = prop224;
				if(ifResult221 = !(OperandVar225))
				{
					applicable = true;
					OperandVar226 = applicable;
				}
			}
			return (System.Boolean) (OperandVar226);
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
			
			Blackboards.aged ContextVar227 = root.AddComponent<Blackboards.aged>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Blackboards.aged ContextVar227 ContextSwitchInterpreter
				if(ContextVar227 != null)
				{
					System.Single OperandVar229 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop228 = External.Random( (20f), (50f)); //IsContext = False IsNew = False
					OperandVar229 = prop228;
					ContextVar227.Age = (System.Int32)( (OperandVar229));
				}
			}
			Entity EntVar230 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar230 != null) EntVar230.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class beaten_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar237 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable231 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable231 != null)
			{
				Blackboards.personality StoredVariable232 = ((Blackboards.personality)StoredVariable231.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable232 != null)
				{
					Blackboards.aged StoredVariable233 = ((Blackboards.aged)StoredVariable232.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable233 != null)
					{
						System.Boolean ifResult234; //IsContext = False IsNew = False
						
						System.Int32 OperandVar236 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop235 = StoredVariable233.CurAge; //IsContext = False IsNew = False
						OperandVar236 = prop235;
						
						
						if(ifResult234 = ( ( (OperandVar236))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar237 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar237);
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
				Blackboards.aged subContext238 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext238 ContextSwitchInterpreter
				if(subContext238 != null)
				{
					
					System.Int32 OperandVar240 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop239 = subContext238.CurAge; //IsContext = False IsNew = False
					OperandVar240 = prop239;
					
					
					subContext238.CurAge = (System.Int32)(( ( (OperandVar240))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext241 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext241 ContextSwitchInterpreter
				if(subContext241 != null)
				{
					
					System.Single OperandVar243 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop242 = subContext241.Cruel; //IsContext = False IsNew = False
					OperandVar243 = prop242;
					
					
					subContext241.Cruel = (System.Single)(( ( (OperandVar243))) + ( ( (0.1f))));
					
					System.Single OperandVar245 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop244 = subContext241.Reckless; //IsContext = False IsNew = False
					OperandVar245 = prop244;
					
					
					subContext241.Reckless = (System.Single)(( ( (OperandVar245))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class cherished_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar252 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable246 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable246 != null)
			{
				Blackboards.personality StoredVariable247 = ((Blackboards.personality)StoredVariable246.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable247 != null)
				{
					Blackboards.aged StoredVariable248 = ((Blackboards.aged)StoredVariable247.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable248 != null)
					{
						System.Boolean ifResult249; //IsContext = False IsNew = False
						
						System.Int32 OperandVar251 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop250 = StoredVariable248.CurAge; //IsContext = False IsNew = False
						OperandVar251 = prop250;
						
						
						if(ifResult249 = ( ( (OperandVar251))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar252 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar252);
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
				Blackboards.aged subContext253 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext253 ContextSwitchInterpreter
				if(subContext253 != null)
				{
					
					System.Int32 OperandVar255 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop254 = subContext253.CurAge; //IsContext = False IsNew = False
					OperandVar255 = prop254;
					
					
					subContext253.CurAge = (System.Int32)(( ( (OperandVar255))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext256 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext256 ContextSwitchInterpreter
				if(subContext256 != null)
				{
					
					System.Single OperandVar258 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop257 = subContext256.Brave; //IsContext = False IsNew = False
					OperandVar258 = prop257;
					
					
					subContext256.Brave = (System.Single)(( ( (OperandVar258))) - ( ( (0.1f))));
					
					System.Single OperandVar260 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop259 = subContext256.Optimistic; //IsContext = False IsNew = False
					OperandVar260 = prop259;
					
					
					subContext256.Optimistic = (System.Single)(( ( (OperandVar260))) + ( ( (0.2f))));
					
					System.Single OperandVar262 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop261 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar262 = prop261;
					
					
					if(( ( (OperandVar262))) > ( ( (0.9f))))
					{
						
						System.Single OperandVar264 = default(System.Single); //IsContext = False IsNew = False
						System.Single prop263 = subContext256.Cruel; //IsContext = False IsNew = False
						OperandVar264 = prop263;
						
						
						subContext256.Cruel = (System.Single)(( ( (OperandVar264))) + ( ( (0.1f))));
					}
					
					System.Single OperandVar266 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop265 = subContext256.Ambitious; //IsContext = False IsNew = False
					OperandVar266 = prop265;
					
					
					subContext256.Ambitious = (System.Single)(( ( (OperandVar266))) - ( ( (0.03f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class inspired_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar273 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable267 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable267 != null)
			{
				Blackboards.personality StoredVariable268 = ((Blackboards.personality)StoredVariable267.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable268 != null)
				{
					Blackboards.aged StoredVariable269 = ((Blackboards.aged)StoredVariable268.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable269 != null)
					{
						System.Boolean ifResult270; //IsContext = False IsNew = False
						
						System.Int32 OperandVar272 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop271 = StoredVariable269.CurAge; //IsContext = False IsNew = False
						OperandVar272 = prop271;
						
						
						if(ifResult270 = ( ( (OperandVar272))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar273 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar273);
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
				Blackboards.aged subContext274 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext274 ContextSwitchInterpreter
				if(subContext274 != null)
				{
					
					System.Int32 OperandVar276 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop275 = subContext274.CurAge; //IsContext = False IsNew = False
					OperandVar276 = prop275;
					
					
					subContext274.CurAge = (System.Int32)(( ( (OperandVar276))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext277 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext277 ContextSwitchInterpreter
				if(subContext277 != null)
				{
					
					System.Single OperandVar279 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop278 = subContext277.Brave; //IsContext = False IsNew = False
					OperandVar279 = prop278;
					
					
					subContext277.Brave = (System.Single)(( ( (OperandVar279))) + ( ( (0.2f))));
					
					System.Single OperandVar281 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop280 = subContext277.Optimistic; //IsContext = False IsNew = False
					OperandVar281 = prop280;
					
					
					subContext277.Optimistic = (System.Single)(( ( (OperandVar281))) + ( ( (0.5f))));
					
					System.Single OperandVar283 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop282 = subContext277.Ambitious; //IsContext = False IsNew = False
					OperandVar283 = prop282;
					
					
					subContext277.Ambitious = (System.Single)(( ( (OperandVar283))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class taught_as_a_kid : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar290 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable284 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable284 != null)
			{
				Blackboards.personality StoredVariable285 = ((Blackboards.personality)StoredVariable284.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable285 != null)
				{
					Blackboards.aged StoredVariable286 = ((Blackboards.aged)StoredVariable285.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable286 != null)
					{
						System.Boolean ifResult287; //IsContext = False IsNew = False
						
						System.Int32 OperandVar289 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop288 = StoredVariable286.CurAge; //IsContext = False IsNew = False
						OperandVar289 = prop288;
						
						
						if(ifResult287 = ( ( (OperandVar289))) < ( ( (6f))))
						{
							applicable = true;
							OperandVar290 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar290);
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
				Blackboards.aged subContext291 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext291 ContextSwitchInterpreter
				if(subContext291 != null)
				{
					
					System.Int32 OperandVar293 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop292 = subContext291.CurAge; //IsContext = False IsNew = False
					OperandVar293 = prop292;
					
					
					subContext291.CurAge = (System.Int32)(( ( (OperandVar293))) + ( ( (3f))));
				}
			}
			
			{
				Blackboards.personality subContext294 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext294 ContextSwitchInterpreter
				if(subContext294 != null)
				{
					
					System.Single OperandVar296 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop295 = subContext294.Rational; //IsContext = False IsNew = False
					OperandVar296 = prop295;
					
					
					subContext294.Rational = (System.Single)(( ( (OperandVar296))) + ( ( (0.1f))));
					
					System.Single OperandVar298 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop297 = subContext294.Ambitious; //IsContext = False IsNew = False
					OperandVar298 = prop297;
					
					
					subContext294.Ambitious = (System.Single)(( ( (OperandVar298))) + ( ( (0.05f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class pushy_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar305 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable299 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable299 != null)
			{
				Blackboards.personality StoredVariable300 = ((Blackboards.personality)StoredVariable299.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable300 != null)
				{
					Blackboards.aged StoredVariable301 = ((Blackboards.aged)StoredVariable300.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable301 != null)
					{
						System.Boolean ifResult302; //IsContext = False IsNew = False
						
						System.Int32 OperandVar304 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop303 = StoredVariable301.CurAge; //IsContext = False IsNew = False
						OperandVar304 = prop303;
						
						
						if(ifResult302 = ( ( (OperandVar304))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar305 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar305);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar308 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable306 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable306 != null)
			{
				System.Single prop307 = StoredVariable306.Brave; //IsContext = False IsNew = False
				OperandVar308 = prop307;
			}
			
			System.Single OperandVar310 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable306 != null)
			{
				System.Single prop309 = StoredVariable306.Ambitious; //IsContext = False IsNew = False
				OperandVar310 = prop309;
			}
			
			System.Single OperandVar312 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable306 != null)
			{
				System.Single prop311 = StoredVariable306.Cruel; //IsContext = False IsNew = False
				OperandVar312 = prop311;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar308))) + ( ( (OperandVar310))) - ( ( (OperandVar312)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext313 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext313 ContextSwitchInterpreter
				if(subContext313 != null)
				{
					
					System.Int32 OperandVar315 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop314 = subContext313.CurAge; //IsContext = False IsNew = False
					OperandVar315 = prop314;
					
					System.Single OperandVar317 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop316 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar317 = prop316;
					subContext313.CurAge = (System.Int32)(( ( (OperandVar315))) + ( ( (OperandVar317))));
				}
			}
			
			{
				Blackboards.personality subContext318 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext318 ContextSwitchInterpreter
				if(subContext318 != null)
				{
					
					System.Single OperandVar320 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop319 = subContext318.Brave; //IsContext = False IsNew = False
					OperandVar320 = prop319;
					
					
					subContext318.Brave = (System.Single)(( ( (OperandVar320))) + ( ( (0.3f))));
					
					System.Single OperandVar322 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop321 = subContext318.Rational; //IsContext = False IsNew = False
					OperandVar322 = prop321;
					
					
					subContext318.Rational = (System.Single)(( ( (OperandVar322))) - ( ( (0.1f))));
					
					System.Single OperandVar324 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop323 = subContext318.Optimistic; //IsContext = False IsNew = False
					OperandVar324 = prop323;
					
					
					subContext318.Optimistic = (System.Single)(( ( (OperandVar324))) + ( ( (0.3f))));
					
					System.Single OperandVar326 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop325 = subContext318.Ambitious; //IsContext = False IsNew = False
					OperandVar326 = prop325;
					
					
					subContext318.Ambitious = (System.Single)(( ( (OperandVar326))) + ( ( (0.1f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class nerd_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar333 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable327 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable327 != null)
			{
				Blackboards.personality StoredVariable328 = ((Blackboards.personality)StoredVariable327.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable328 != null)
				{
					Blackboards.aged StoredVariable329 = ((Blackboards.aged)StoredVariable328.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable329 != null)
					{
						System.Boolean ifResult330; //IsContext = False IsNew = False
						
						System.Int32 OperandVar332 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop331 = StoredVariable329.CurAge; //IsContext = False IsNew = False
						OperandVar332 = prop331;
						
						
						if(ifResult330 = ( ( (OperandVar332))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar333 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar333);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar336 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable334 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable334 != null)
			{
				System.Single prop335 = StoredVariable334.Rational; //IsContext = False IsNew = False
				OperandVar336 = prop335;
			}
			
			System.Single OperandVar338 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable334 != null)
			{
				System.Single prop337 = StoredVariable334.Brave; //IsContext = False IsNew = False
				OperandVar338 = prop337;
			}
			return (System.Single)( ( (0.3f))) + ( ( (OperandVar336))) - ( ( (OperandVar338)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext339 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext339 ContextSwitchInterpreter
				if(subContext339 != null)
				{
					
					System.Int32 OperandVar341 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop340 = subContext339.CurAge; //IsContext = False IsNew = False
					OperandVar341 = prop340;
					
					System.Single OperandVar343 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop342 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar343 = prop342;
					subContext339.CurAge = (System.Int32)(( ( (OperandVar341))) + ( ( (OperandVar343))));
				}
			}
			
			{
				Blackboards.personality subContext344 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext344 ContextSwitchInterpreter
				if(subContext344 != null)
				{
					
					System.Single OperandVar346 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop345 = subContext344.Brave; //IsContext = False IsNew = False
					OperandVar346 = prop345;
					
					
					subContext344.Brave = (System.Single)(( ( (OperandVar346))) - ( ( (0.1f))));
					
					System.Single OperandVar348 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop347 = subContext344.Rational; //IsContext = False IsNew = False
					OperandVar348 = prop347;
					
					
					subContext344.Rational = (System.Single)(( ( (OperandVar348))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class manipulative_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar355 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable349 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable349 != null)
			{
				Blackboards.personality StoredVariable350 = ((Blackboards.personality)StoredVariable349.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable350 != null)
				{
					Blackboards.aged StoredVariable351 = ((Blackboards.aged)StoredVariable350.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable351 != null)
					{
						System.Boolean ifResult352; //IsContext = False IsNew = False
						
						System.Int32 OperandVar354 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop353 = StoredVariable351.CurAge; //IsContext = False IsNew = False
						OperandVar354 = prop353;
						
						
						if(ifResult352 = ( ( (OperandVar354))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar355 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar355);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			
			
			System.Single OperandVar358 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable356 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable356 != null)
			{
				System.Single prop357 = StoredVariable356.Rational; //IsContext = False IsNew = False
				OperandVar358 = prop357;
			}
			
			System.Single OperandVar360 = default(System.Single); //IsContext = False IsNew = False
			if(StoredVariable356 != null)
			{
				System.Single prop359 = StoredVariable356.Ambitious; //IsContext = False IsNew = False
				OperandVar360 = prop359;
			}
			return (System.Single)( ( (0.2f))) + ( ( (OperandVar358))) + ( ( (OperandVar360)));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext361 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext361 ContextSwitchInterpreter
				if(subContext361 != null)
				{
					
					System.Int32 OperandVar363 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop362 = subContext361.CurAge; //IsContext = False IsNew = False
					OperandVar363 = prop362;
					
					System.Single OperandVar365 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop364 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar365 = prop364;
					subContext361.CurAge = (System.Int32)(( ( (OperandVar363))) + ( ( (OperandVar365))));
				}
			}
			
			{
				Blackboards.personality subContext366 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext366 ContextSwitchInterpreter
				if(subContext366 != null)
				{
					
					System.Single OperandVar368 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop367 = subContext366.Brave; //IsContext = False IsNew = False
					OperandVar368 = prop367;
					
					
					subContext366.Brave = (System.Single)(( ( (OperandVar368))) - ( ( (0.2f))));
					
					System.Single OperandVar370 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop369 = subContext366.Ambitious; //IsContext = False IsNew = False
					OperandVar370 = prop369;
					
					
					subContext366.Ambitious = (System.Single)(( ( (OperandVar370))) + ( ( (0.3f))));
					
					System.Single OperandVar372 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop371 = subContext366.Reckless; //IsContext = False IsNew = False
					OperandVar372 = prop371;
					
					
					subContext366.Reckless = (System.Single)(( ( (OperandVar372))) + ( ( (0.2f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=true, Category="person_generation", OncePerObject=true, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class tortured_pets_teen : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar379 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable373 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable373 != null)
			{
				Blackboards.personality StoredVariable374 = ((Blackboards.personality)StoredVariable373.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable374 != null)
				{
					Blackboards.aged StoredVariable375 = ((Blackboards.aged)StoredVariable374.GetComponent(typeof(Blackboards.aged))); //IsContext = False IsNew = False
					if(StoredVariable375 != null)
					{
						System.Boolean ifResult376; //IsContext = False IsNew = False
						
						System.Int32 OperandVar378 = default(System.Int32); //IsContext = False IsNew = False
						System.Int32 prop377 = StoredVariable375.CurAge; //IsContext = False IsNew = False
						OperandVar378 = prop377;
						
						
						if(ifResult376 = ( ( (OperandVar378))) < ( ( (15f))))
						{
							applicable = true;
							OperandVar379 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar379);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Single OperandVar382 = default(System.Single); //IsContext = False IsNew = False
			Blackboards.personality StoredVariable380 = ((Blackboards.personality)root.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
			if(StoredVariable380 != null)
			{
				System.Single prop381 = StoredVariable380.Cruel; //IsContext = False IsNew = False
				OperandVar382 = prop381;
			}
			
			return (System.Single)( (OperandVar382)) * ( (0.8f));
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.aged subContext383 = (Blackboards.aged)root.GetComponent(typeof(Blackboards.aged)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.aged subContext383 ContextSwitchInterpreter
				if(subContext383 != null)
				{
					
					System.Int32 OperandVar385 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop384 = subContext383.CurAge; //IsContext = False IsNew = False
					OperandVar385 = prop384;
					
					System.Single OperandVar387 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop386 = External.Random( (3f), (5f)); //IsContext = False IsNew = False
					OperandVar387 = prop386;
					subContext383.CurAge = (System.Int32)(( ( (OperandVar385))) + ( ( (OperandVar387))));
				}
			}
			
			{
				Blackboards.personality subContext388 = (Blackboards.personality)root.GetComponent(typeof(Blackboards.personality)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.personality subContext388 ContextSwitchInterpreter
				if(subContext388 != null)
				{
					
					System.Single OperandVar390 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop389 = subContext388.Rational; //IsContext = False IsNew = False
					OperandVar390 = prop389;
					
					
					subContext388.Rational = (System.Single)(( ( (OperandVar390))) - ( ( (0.1f))));
					
					System.Single OperandVar392 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop391 = subContext388.Cruel; //IsContext = False IsNew = False
					OperandVar392 = prop391;
					
					
					subContext388.Cruel = (System.Single)(( ( (OperandVar392))) + ( ( (0.5f))));
					
					System.Single OperandVar394 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop393 = subContext388.Reckless; //IsContext = False IsNew = False
					OperandVar394 = prop393;
					
					
					subContext388.Reckless = (System.Single)(( ( (OperandVar394))) + ( ( (0.5f))));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar408 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable395 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable395 != null)
			{
				Markers StoredVariable396 = ((Markers)StoredVariable395.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable396 != null)
				{
					System.Boolean ifResult397; //IsContext = False IsNew = False
					
					System.Boolean OperandVar404 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable395 != null)
					{
						UnityEngine.GameObject prop398 = StoredVariable395.ShowedObject; //IsContext = False IsNew = False
						if(prop398 != null)
						{
							System.Boolean ifResult399; //IsContext = False IsNew = False
							System.Boolean OperandVar403 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar401 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable400 = ((Named)prop398.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable400 != null)
							{
								OperandVar401 = StoredVariable400;
							}
							System.Boolean prop402 = External.Has( (OperandVar401)); //IsContext = False IsNew = False
							OperandVar403 = prop402;
							if(ifResult399 =  (OperandVar403))
							{
								OperandVar404 = ifResult399;
							}
						}
					}
					
					System.Boolean OperandVar407 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar405 = default(System.String); //IsContext = False IsNew = False
					OperandVar405 = "named_ui_marker";
					System.Boolean prop406 = StoredVariable396.HasMarker( (OperandVar405)); //IsContext = False IsNew = False
					OperandVar407 = prop406;
					if(ifResult397 = ( ( (OperandVar404))) && ( (!(OperandVar407))))
					{
						applicable = true;
						OperandVar408 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar408);
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
			
			UnityEngine.GameObject OperandVar409 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar409 = root;
			UnityEngine.GameObject ctx =  (OperandVar409); //IsContext = False IsNew = False
			
			{
				BarsManager subContext410 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext410 ContextSwitchInterpreter
				if(subContext410 != null)
				{
					UnityEngine.GameObject OperandVar412 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop411 = subContext410.GetLeftBar(); //IsContext = False IsNew = False
					if(prop411 != null)
					{
						OperandVar412 = prop411;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar412); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext413 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext413 ContextPropertySwitchInterpreter
						if(subContext413 != null)
						{
							System.Boolean OperandVar417 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar415 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable414 = ((UiObject)subContext413.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable414 != null)
							{
								OperandVar415 = StoredVariable414;
							}
							System.Boolean prop416 = External.Has( (OperandVar415)); //IsContext = False IsNew = False
							OperandVar417 = prop416;
							if( (OperandVar417))
							{
								UnityEngine.GameObject OperandVar418 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar418 = p_ctx;
								ctx =  (OperandVar418);
							}
						}
					}
				}
			}
			
			{
				Markers subContext419 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext419 ContextSwitchInterpreter
				if(subContext419 != null)
				{
					System.String OperandVar420 = default(System.String); //IsContext = False IsNew = False
					OperandVar420 = "named_ui_marker";
					subContext419.SetUiMarker(( (OperandVar420)).ToString());
				}
			}
			
			{
				UnityEngine.GameObject subContext421 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext421 ContextPropertySwitchInterpreter
				if(subContext421 != null)
				{
					
					{
						UiObject subContext422 = (UiObject)subContext421.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
						//ContextStatement UiObject subContext422 ContextSwitchInterpreter
						if(subContext422 != null)
						{
							Named OperandVar425 = default(Named); //IsContext = False IsNew = False
							UnityEngine.GameObject prop423 = subContext422.ShowedObject; //IsContext = False IsNew = False
							if(prop423 != null)
							{
								Named StoredVariable424 = ((Named)prop423.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable424 != null)
								{
									OperandVar425 = StoredVariable424;
								}
							}
							Named showed_named =  (OperandVar425); //IsContext = False IsNew = False
							TextField ContextVar426 = subContext421.AddComponent<TextField>();; //IsContext = False IsNew = True
							
							{
								//ContextStatement TextField ContextVar426 ContextSwitchInterpreter
								if(ContextVar426 != null)
								{
									System.String OperandVar428 = default(System.String); //IsContext = False IsNew = False
									System.String prop427 = showed_named.FullName; //IsContext = False IsNew = False
									if(prop427 != null)
									{
										OperandVar428 = prop427;
									}
									ContextVar426.Show(( (OperandVar428)).ToString());
									
									{
										//ContextStatement Named showed_named ContextSwitchInterpreter
										if(showed_named != null)
										{
											VoidDelegate Lambda429 = () => 
											{
												System.String OperandVar431 = default(System.String); //IsContext = False IsNew = False
												System.String prop430 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop430 != null)
												{
													OperandVar431 = prop430;
												}
												ContextVar426.Show(( (OperandVar431)).ToString());
											};
											showed_named.OnUpdate(Lambda429);
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext432 = ContextVar426.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext432 ContextPropertySwitchInterpreter
										if(subContext432 != null)
										{
											
											subContext432.minHeight = (System.Single)( (20f));
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext433 = ContextVar426.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext433 ContextPropertySwitchInterpreter
										if(subContext433 != null)
										{
											
											subContext433.minWidth = (System.Single)( (100f));
										}
									}
								}
							}
							Entity EntVar434 = (Entity)subContext421.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
							if(EntVar434 != null) EntVar434.ComponentAdded();
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar443 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable435 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable435 != null)
			{
				Place StoredVariable436 = ((Place)StoredVariable435.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable436 != null)
				{
					System.Boolean ifResult437; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar439 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop438 = StoredVariable436.Agents; //IsContext = False IsNew = False
					if(prop438 != null)
					{
						OperandVar439 = prop438;
					}
					
					
					
					System.Boolean OperandVar442 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar440 = default(System.String); //IsContext = False IsNew = False
					OperandVar440 = "agents_pool";
					System.Boolean prop441 = StoredVariable435.HasMarker( (OperandVar440)); //IsContext = False IsNew = False
					OperandVar442 = prop441;
					if(ifResult437 = ( (( ( (OperandVar439 != null ? OperandVar439.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar442))))
					{
						applicable = true;
						OperandVar443 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar443);
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
				Place subContext444 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext444 ContextSwitchInterpreter
				if(subContext444 != null)
				{
					
					subContext444.Size = (System.Int32)( (5f));
					System.Single OperandVar446 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop445 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar446 = prop445;
					for (int i = 0; i <  (OperandVar446); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag447 = ag; //IsContext = True IsNew = False
							Entity AddContext448 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext449 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext450 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext450 ContextSwitchInterpreter
								if(AddContext450 != null)
								{
									System.Single OperandVar452 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop451 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar452 = prop451;
									AddContext450.Age = (System.Int32)( (OperandVar452));
								}
							}
							Named AddContext453 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext453 ContextSwitchInterpreter
								if(AddContext453 != null)
								{
									
									
									
									AddContext453.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar456 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar454 = default(System.String); //IsContext = False IsNew = False
									OperandVar454 = "human_name";
									System.String prop455 = External.RandomName( (OperandVar454)); //IsContext = False IsNew = False
									if(prop455 != null)
									{
										OperandVar456 = prop455;
									}
									AddContext453.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar456)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar458 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable457 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable457 != null)
						{
							OperandVar458 = StoredVariable457;
						}
						subContext444.Attach((Agent)( (OperandVar458)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar465 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable459 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable459 != null)
			{
				System.Boolean ifResult460; //IsContext = False IsNew = False
				System.Boolean OperandVar464 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar462 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable461 = ((Blackboards.event_marker)StoredVariable459.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable461 != null)
				{
					OperandVar462 = StoredVariable461;
				}
				System.Boolean prop463 = External.Has( (OperandVar462)); //IsContext = False IsNew = False
				OperandVar464 = prop463;
				if(ifResult460 = !(OperandVar464))
				{
					applicable = true;
					OperandVar465 = applicable;
				}
			}
			return (System.Boolean) (OperandVar465);
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
			Entity EntVar466 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar466 != null) EntVar466.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar468 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable467 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable467 != null)
			{
				applicable = true;
				OperandVar468 = applicable;
			}
			return (System.Boolean) (OperandVar468);
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
			
			UnityEngine.GameObject OperandVar469 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar469 = root;
			External.MapEnlistDetailed((UnityEngine.GameObject)( (OperandVar469)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar476 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable470 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable470 != null)
			{
				Markers StoredVariable471 = ((Markers)StoredVariable470.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable471 != null)
				{
					System.Boolean ifResult472; //IsContext = False IsNew = False
					System.Boolean OperandVar475 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar473 = default(System.String); //IsContext = False IsNew = False
					OperandVar473 = "encounter_ui_enlist";
					System.Boolean prop474 = StoredVariable471.HasMarker( (OperandVar473)); //IsContext = False IsNew = False
					OperandVar475 = prop474;
					if(ifResult472 = !(OperandVar475))
					{
						applicable = true;
						OperandVar476 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar476);
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
				Markers subContext477 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext477 ContextSwitchInterpreter
				if(subContext477 != null)
				{
					System.String OperandVar478 = default(System.String); //IsContext = False IsNew = False
					OperandVar478 = "encounter_ui_enlist";
					subContext477.SetUiMarker(( (OperandVar478)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar479 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar479 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar479)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar485 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable480 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable480 != null)
			{
				Named StoredVariable481 = ((Named)StoredVariable480.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable481 != null)
				{
					System.Boolean ifResult482; //IsContext = False IsNew = False
					
					System.Boolean OperandVar484 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable480 != null)
					{
						System.Boolean prop483 = StoredVariable480.Act; //IsContext = False IsNew = False
						OperandVar484 = prop483;
					}
					
					
					if(ifResult482 = ( ( (OperandVar484))) == ( ( (true))))
					{
						applicable = true;
						OperandVar485 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar485);
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
				UnityEngine.GameObject enc486 = enc; //IsContext = True IsNew = False
				Encounter AddContext487 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext487 ContextSwitchInterpreter
					if(AddContext487 != null)
					{
						UnityEngine.GameObject OperandVar488 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar488 = root;
						AddContext487.Context = (UnityEngine.GameObject)( (OperandVar488));
					}
				}
				Markers AddContext489 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext490 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext491 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext491 ContextSwitchInterpreter
					if(AddContext491 != null)
					{
						System.String OperandVar492 = default(System.String); //IsContext = False IsNew = False
						OperandVar492 = "main_name";
						
						
						AddContext491.Set(( (OperandVar492)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar506 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable493 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable493 != null)
			{
				Markers StoredVariable494 = ((Markers)StoredVariable493.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable494 != null)
				{
					System.Boolean ifResult495; //IsContext = False IsNew = False
					
					System.Boolean OperandVar502 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable493 != null)
					{
						UnityEngine.GameObject prop496 = StoredVariable493.ShowedObject; //IsContext = False IsNew = False
						if(prop496 != null)
						{
							System.Boolean ifResult497; //IsContext = False IsNew = False
							System.Boolean OperandVar501 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar499 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable498 = ((Place)prop496.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable498 != null)
							{
								OperandVar499 = StoredVariable498;
							}
							System.Boolean prop500 = External.Has( (OperandVar499)); //IsContext = False IsNew = False
							OperandVar501 = prop500;
							if(ifResult497 =  (OperandVar501))
							{
								OperandVar502 = ifResult497;
							}
						}
					}
					
					System.Boolean OperandVar505 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar503 = default(System.String); //IsContext = False IsNew = False
					OperandVar503 = "place_ui_cards_list";
					System.Boolean prop504 = StoredVariable494.HasMarker( (OperandVar503)); //IsContext = False IsNew = False
					OperandVar505 = prop504;
					if(ifResult495 = ( ( (OperandVar502))) && ( (!(OperandVar505))))
					{
						applicable = true;
						OperandVar506 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar506);
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
			
			UnityEngine.GameObject OperandVar507 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar507 = root;
			UnityEngine.GameObject ctx =  (OperandVar507); //IsContext = False IsNew = False
			
			{
				BarsManager subContext508 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext508 ContextSwitchInterpreter
				if(subContext508 != null)
				{
					UnityEngine.GameObject OperandVar510 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop509 = subContext508.GetBottomBar(); //IsContext = False IsNew = False
					if(prop509 != null)
					{
						OperandVar510 = prop509;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar510); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext511 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext511 ContextPropertySwitchInterpreter
						if(subContext511 != null)
						{
							System.Boolean OperandVar515 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar513 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable512 = ((UiObject)subContext511.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable512 != null)
							{
								OperandVar513 = StoredVariable512;
							}
							System.Boolean prop514 = External.Has( (OperandVar513)); //IsContext = False IsNew = False
							OperandVar515 = prop514;
							if( (OperandVar515))
							{
								UnityEngine.GameObject OperandVar516 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar516 = p_ctx;
								ctx =  (OperandVar516);
							}
						}
					}
				}
			}
			
			{
				Markers subContext517 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext517 ContextSwitchInterpreter
				if(subContext517 != null)
				{
					System.String OperandVar518 = default(System.String); //IsContext = False IsNew = False
					OperandVar518 = "place_ui_cards_list";
					subContext517.SetUiMarker(( (OperandVar518)).ToString());
				}
			}
			Place OperandVar522 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable519 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable519 != null)
			{
				UnityEngine.GameObject prop520 = StoredVariable519.ShowedObject; //IsContext = False IsNew = False
				if(prop520 != null)
				{
					Place StoredVariable521 = ((Place)prop520.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable521 != null)
					{
						OperandVar522 = StoredVariable521;
					}
				}
			}
			Place pl =  (OperandVar522); //IsContext = False IsNew = False
			System.String OperandVar523 = default(System.String); //IsContext = False IsNew = False
			OperandVar523 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx524 = External.SpawnPrefab(( (OperandVar523)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx524 ContextPropertySwitchInterpreter
				if(FuncCtx524 != null)
				{
					
					{
						AgentsUI subContext525 = (AgentsUI)FuncCtx524.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext525 ContextSwitchInterpreter
						if(subContext525 != null)
						{
							Place OperandVar526 = default(Place); //IsContext = False IsNew = False
							OperandVar526 = pl;
							subContext525.TargetPlace = (Place)( (OperandVar526));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext527 = (CardsHolderAgentsAdapter)FuncCtx524.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext527 ContextSwitchInterpreter
						if(subContext527 != null)
						{
							Place OperandVar528 = default(Place); //IsContext = False IsNew = False
							OperandVar528 = pl;
							subContext527.TargetPlace = (Place)( (OperandVar528));
						}
					}
					UnityEngine.GameObject OperandVar529 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar529 = FuncCtx524;
					UnityEngine.GameObject OperandVar530 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar530 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar529)),(UnityEngine.GameObject)( (OperandVar530)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar536 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable531 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable531 != null)
			{
				System.Boolean ifResult532; //IsContext = False IsNew = False
				System.Boolean OperandVar535 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop533 = StoredVariable531.ShowedObject; //IsContext = False IsNew = False
				if(prop533 != null)
				{
					Place StoredVariable534 = ((Place)prop533.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable534 != null)
					{
						applicable = true;
						OperandVar535 = applicable;
					}
				}
				if(ifResult532 =  (OperandVar535))
				{
					applicable = true;
					OperandVar536 = applicable;
				}
			}
			return (System.Boolean) (OperandVar536);
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
			
			UnityEngine.GameObject OperandVar537 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar537 = root;
			UnityEngine.GameObject ctx =  (OperandVar537); //IsContext = False IsNew = False
			
			{
				BarsManager subContext538 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext538 ContextSwitchInterpreter
				if(subContext538 != null)
				{
					UnityEngine.GameObject OperandVar540 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop539 = subContext538.GetLeftBar(); //IsContext = False IsNew = False
					if(prop539 != null)
					{
						OperandVar540 = prop539;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar540); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext541 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext541 ContextPropertySwitchInterpreter
						if(subContext541 != null)
						{
							System.Boolean OperandVar545 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar543 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable542 = ((UiObject)subContext541.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable542 != null)
							{
								OperandVar543 = StoredVariable542;
							}
							System.Boolean prop544 = External.Has( (OperandVar543)); //IsContext = False IsNew = False
							OperandVar545 = prop544;
							if( (OperandVar545))
							{
								UnityEngine.GameObject OperandVar546 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar546 = p_ctx;
								ctx =  (OperandVar546);
							}
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext547 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext547 ContextPropertySwitchInterpreter
				if(subContext547 != null)
				{
					TextField ContextVar548 = subContext547.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar548 ContextSwitchInterpreter
						if(ContextVar548 != null)
						{
							
							ContextVar548.Label = (System.String)( ("size"));
							System.Int32 OperandVar553 = default(System.Int32); //IsContext = False IsNew = False
							UiObject StoredVariable549 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable549 != null)
							{
								UnityEngine.GameObject prop550 = StoredVariable549.ShowedObject; //IsContext = False IsNew = False
								if(prop550 != null)
								{
									Place StoredVariable551 = ((Place)prop550.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable551 != null)
									{
										System.Int32 prop552 = StoredVariable551.Size; //IsContext = False IsNew = False
										OperandVar553 = prop552;
									}
								}
							}
							ContextVar548.Show(( (OperandVar553)).ToString());
							
							{
								UnityEngine.UI.LayoutElement subContext554 = ContextVar548.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext554 ContextPropertySwitchInterpreter
								if(subContext554 != null)
								{
									
									subContext554.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext555 = ContextVar548.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext555 ContextPropertySwitchInterpreter
								if(subContext555 != null)
								{
									
									subContext555.minWidth = (System.Single)( (100f));
								}
							}
						}
					}
					Entity EntVar556 = (Entity)subContext547.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar556 != null) EntVar556.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class interactables_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar566 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable557 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable557 != null)
			{
				System.Boolean ifResult558; //IsContext = False IsNew = False
				System.Boolean OperandVar565 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop559 = StoredVariable557.ShowedObject; //IsContext = False IsNew = False
				if(prop559 != null)
				{
					System.Boolean ifResult560; //IsContext = False IsNew = False
					System.Boolean OperandVar564 = default(System.Boolean); //IsContext = False IsNew = False
					Interactables OperandVar562 = default(Interactables); //IsContext = False IsNew = False
					Interactables StoredVariable561 = ((Interactables)prop559.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
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
				if(ifResult558 =  (OperandVar565))
				{
					applicable = true;
					OperandVar566 = applicable;
				}
			}
			return (System.Boolean) (OperandVar566);
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
			
			UnityEngine.GameObject OperandVar567 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar567 = root;
			UnityEngine.GameObject ctx =  (OperandVar567); //IsContext = False IsNew = False
			
			{
				BarsManager subContext568 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext568 ContextSwitchInterpreter
				if(subContext568 != null)
				{
					UnityEngine.GameObject OperandVar570 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop569 = subContext568.GetTopBar(); //IsContext = False IsNew = False
					if(prop569 != null)
					{
						OperandVar570 = prop569;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar570); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext571 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext571 ContextPropertySwitchInterpreter
						if(subContext571 != null)
						{
							System.Boolean OperandVar575 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar573 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable572 = ((UiObject)subContext571.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable572 != null)
							{
								OperandVar573 = StoredVariable572;
							}
							System.Boolean prop574 = External.Has( (OperandVar573)); //IsContext = False IsNew = False
							OperandVar575 = prop574;
							if( (OperandVar575))
							{
								UnityEngine.GameObject OperandVar576 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar576 = p_ctx;
								ctx =  (OperandVar576);
							}
						}
					}
				}
			}
			Interactables OperandVar580 = default(Interactables); //IsContext = False IsNew = False
			UiObject StoredVariable577 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable577 != null)
			{
				UnityEngine.GameObject prop578 = StoredVariable577.ShowedObject; //IsContext = False IsNew = False
				if(prop578 != null)
				{
					Interactables StoredVariable579 = ((Interactables)prop578.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable579 != null)
					{
						OperandVar580 = StoredVariable579;
					}
				}
			}
			Interactables inter =  (OperandVar580); //IsContext = False IsNew = False
			System.String OperandVar581 = default(System.String); //IsContext = False IsNew = False
			OperandVar581 = "interactables_ui";
			
			{
				UnityEngine.GameObject FuncCtx582 = External.SpawnPrefab(( (OperandVar581)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx582 ContextPropertySwitchInterpreter
				if(FuncCtx582 != null)
				{
					
					{
						InteractablesUI subContext583 = (InteractablesUI)FuncCtx582.GetComponent(typeof(InteractablesUI)); //IsContext = True IsNew = False
						//ContextStatement InteractablesUI subContext583 ContextSwitchInterpreter
						if(subContext583 != null)
						{
							Interactables OperandVar584 = default(Interactables); //IsContext = False IsNew = False
							OperandVar584 = inter;
							subContext583.TargetInteractables = (Interactables)( (OperandVar584));
						}
					}
					UnityEngine.GameObject OperandVar585 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar585 = FuncCtx582;
					UnityEngine.GameObject OperandVar586 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar586 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar585)),(UnityEngine.GameObject)( (OperandVar586)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class interactable_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar600 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable587 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable587 != null)
			{
				System.Boolean ifResult588; //IsContext = False IsNew = False
				
				System.Boolean OperandVar595 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop589 = StoredVariable587.ShowedObject; //IsContext = False IsNew = False
				if(prop589 != null)
				{
					System.Boolean ifResult590; //IsContext = False IsNew = False
					System.Boolean OperandVar594 = default(System.Boolean); //IsContext = False IsNew = False
					Interactable OperandVar592 = default(Interactable); //IsContext = False IsNew = False
					Interactable StoredVariable591 = ((Interactable)prop589.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
					if(StoredVariable591 != null)
					{
						OperandVar592 = StoredVariable591;
					}
					System.Boolean prop593 = External.Has( (OperandVar592)); //IsContext = False IsNew = False
					OperandVar594 = prop593;
					if(ifResult590 =  (OperandVar594))
					{
						OperandVar595 = ifResult590;
					}
				}
				
				System.Boolean OperandVar599 = default(System.Boolean); //IsContext = False IsNew = False
				SelectableMarker OperandVar597 = default(SelectableMarker); //IsContext = False IsNew = False
				SelectableMarker StoredVariable596 = ((SelectableMarker)StoredVariable587.GetComponent(typeof(SelectableMarker))); //IsContext = False IsNew = False
				if(StoredVariable596 != null)
				{
					OperandVar597 = StoredVariable596;
				}
				System.Boolean prop598 = External.Has( (OperandVar597)); //IsContext = False IsNew = False
				OperandVar599 = prop598;
				if(ifResult588 = ( ( (OperandVar595))) && ( (!(OperandVar599))))
				{
					applicable = true;
					OperandVar600 = applicable;
				}
			}
			return (System.Boolean) (OperandVar600);
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
			
			
			External.Log((System.Object)( ("interactable UI")));
			UnityEngine.GameObject OperandVar601 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar601 = root;
			UnityEngine.GameObject ctx =  (OperandVar601); //IsContext = False IsNew = False
			
			{
				BarsManager subContext602 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext602 ContextSwitchInterpreter
				if(subContext602 != null)
				{
					UnityEngine.GameObject OperandVar604 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop603 = subContext602.GetRightBar(); //IsContext = False IsNew = False
					if(prop603 != null)
					{
						OperandVar604 = prop603;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar604); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext605 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext605 ContextPropertySwitchInterpreter
						if(subContext605 != null)
						{
							System.Boolean OperandVar609 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar607 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable606 = ((UiObject)subContext605.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable606 != null)
							{
								OperandVar607 = StoredVariable606;
							}
							System.Boolean prop608 = External.Has( (OperandVar607)); //IsContext = False IsNew = False
							OperandVar609 = prop608;
							if( (OperandVar609))
							{
								UnityEngine.GameObject OperandVar610 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar610 = p_ctx;
								ctx =  (OperandVar610);
							}
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext611 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext611 ContextPropertySwitchInterpreter
				if(subContext611 != null)
				{
					System.String OperandVar612 = default(System.String); //IsContext = False IsNew = False
					OperandVar612 = "interactions_ui";
					
					{
						UnityEngine.GameObject FuncCtx613 = External.SpawnPrefab(( (OperandVar612)).ToString());; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject FuncCtx613 ContextPropertySwitchInterpreter
						if(FuncCtx613 != null)
						{
							
							{
								InteractableUI subContext614 = (InteractableUI)FuncCtx613.GetComponent(typeof(InteractableUI)); //IsContext = True IsNew = False
								//ContextStatement InteractableUI subContext614 ContextSwitchInterpreter
								if(subContext614 != null)
								{
									Interactable OperandVar618 = default(Interactable); //IsContext = False IsNew = False
									UiObject StoredVariable615 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
									if(StoredVariable615 != null)
									{
										UnityEngine.GameObject prop616 = StoredVariable615.ShowedObject; //IsContext = False IsNew = False
										if(prop616 != null)
										{
											Interactable StoredVariable617 = ((Interactable)prop616.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
											if(StoredVariable617 != null)
											{
												OperandVar618 = StoredVariable617;
											}
										}
									}
									subContext614.TargetInteractable = (Interactable)( (OperandVar618));
								}
							}
							UnityEngine.GameObject OperandVar619 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar619 = FuncCtx613;
							UnityEngine.GameObject OperandVar620 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar620 = ctx;
							External.SetParent((UnityEngine.GameObject)( (OperandVar619)),(UnityEngine.GameObject)( (OperandVar620)));
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip=("show this interactable object name to Debug console"), OnceInCategory=false)]
    public class interaction_log_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar623 = default(System.Boolean); //IsContext = False IsNew = False
			Interactable StoredVariable621 = ((Interactable)root.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
			if(StoredVariable621 != null)
			{
				Named StoredVariable622 = ((Named)StoredVariable621.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable622 != null)
				{
					applicable = true;
					OperandVar623 = applicable;
				}
			}
			return (System.Boolean) (OperandVar623);
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
			
			System.String OperandVar626 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable624 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable624 != null)
			{
				System.String prop625 = StoredVariable624.FullName; //IsContext = False IsNew = False
				if(prop625 != null)
				{
					OperandVar626 = prop625;
				}
			}
			External.Log((System.Object)( (OperandVar626)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class inquisitor_basic_resources : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar628 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable627 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable627 != null)
			{
				applicable = true;
				OperandVar628 = applicable;
			}
			return (System.Boolean) (OperandVar628);
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
			
			
			External.Gold = (System.Int32)( (100f));
			
			External.Influence = (System.Int32)( (100f));
			
			External.Sanity = (System.Int32)( (100f));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=true, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class on_check_lose : EventAction {
        
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
			
			System.Boolean OperandVar637 = default(System.Boolean); //IsContext = False IsNew = False
			InquisitorResources StoredVariable629 = ((InquisitorResources)root.GetComponent(typeof(InquisitorResources))); //IsContext = False IsNew = False
			if(StoredVariable629 != null)
			{
				Markers StoredVariable630 = ((Markers)StoredVariable629.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable630 != null)
				{
					System.Boolean ifResult631; //IsContext = False IsNew = False
					
					
					System.Int32 OperandVar633 = default(System.Int32); //IsContext = False IsNew = False
					System.Int32 prop632 = External.CurrentDate(); //IsContext = False IsNew = False
					OperandVar633 = prop632;
					
					
					
					System.Boolean OperandVar636 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar634 = default(System.String); //IsContext = False IsNew = False
					OperandVar634 = "lost";
					System.Boolean prop635 = StoredVariable630.HasMarker( (OperandVar634)); //IsContext = False IsNew = False
					OperandVar636 = prop635;
					if(ifResult631 = ( (( ( (OperandVar633))) > ( ( (0f))))) && ( (!(OperandVar636))))
					{
						applicable = true;
						OperandVar637 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar637);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			System.Int32 OperandVar639 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop638 = External.Sanity; //IsContext = False IsNew = False
			OperandVar639 = prop638;
			
			
			if(( ( (OperandVar639))) == ( ( (0f))))
			{
				System.String OperandVar640 = default(System.String); //IsContext = False IsNew = False
				OperandVar640 = "you_in_the_cult_now";
				External.Lose(( (OperandVar640)).ToString());
				
				{
					Markers subContext641 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext641 ContextSwitchInterpreter
					if(subContext641 != null)
					{
						System.String OperandVar642 = default(System.String); //IsContext = False IsNew = False
						OperandVar642 = "lost";
						subContext641.SetMarker(( (OperandVar642)).ToString());
					}
				}
			}
			
			System.Int32 OperandVar644 = default(System.Int32); //IsContext = False IsNew = False
			System.Int32 prop643 = External.Influence; //IsContext = False IsNew = False
			OperandVar644 = prop643;
			
			
			if(( ( (OperandVar644))) == ( ( (0f))))
			{
				System.String OperandVar645 = default(System.String); //IsContext = False IsNew = False
				OperandVar645 = "they_fired_you";
				External.Lose(( (OperandVar645)).ToString());
				
				{
					Markers subContext646 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
					//ContextStatement Markers subContext646 ContextSwitchInterpreter
					if(subContext646 != null)
					{
						System.String OperandVar647 = default(System.String); //IsContext = False IsNew = False
						OperandVar647 = "lost";
						subContext646.SetMarker(( (OperandVar647)).ToString());
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class lose_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar651 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable648 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable648 != null)
			{
				UnityEngine.GameObject prop649 = StoredVariable648.ShowedObject; //IsContext = False IsNew = False
				if(prop649 != null)
				{
					LostEvent StoredVariable650 = ((LostEvent)prop649.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
					if(StoredVariable650 != null)
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
				EncounterUi subContext652 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext652 ContextSwitchInterpreter
				if(subContext652 != null)
				{
					System.String OperandVar657 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable653 = ((EncounterUi)subContext652.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable653 != null)
					{
						UnityEngine.GameObject prop654 = StoredVariable653.ShowedObject; //IsContext = False IsNew = False
						if(prop654 != null)
						{
							LostEvent StoredVariable655 = ((LostEvent)prop654.GetComponent(typeof(LostEvent))); //IsContext = False IsNew = False
							if(StoredVariable655 != null)
							{
								System.String prop656 = StoredVariable655.Why; //IsContext = False IsNew = False
								if(prop656 != null)
								{
									OperandVar657 = prop656;
								}
							}
						}
					}
					subContext652.Description = (System.String)( (OperandVar657));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="", OnceInCategory=false)]
    public class win_encounter_explain : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar661 = default(System.Boolean); //IsContext = False IsNew = False
			EncounterUi StoredVariable658 = ((EncounterUi)root.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
			if(StoredVariable658 != null)
			{
				UnityEngine.GameObject prop659 = StoredVariable658.ShowedObject; //IsContext = False IsNew = False
				if(prop659 != null)
				{
					WinEvent StoredVariable660 = ((WinEvent)prop659.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
					if(StoredVariable660 != null)
					{
						applicable = true;
						OperandVar661 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar661);
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
				EncounterUi subContext662 = (EncounterUi)root.GetComponent(typeof(EncounterUi)); //IsContext = True IsNew = False
				//ContextStatement EncounterUi subContext662 ContextSwitchInterpreter
				if(subContext662 != null)
				{
					System.String OperandVar667 = default(System.String); //IsContext = False IsNew = False
					EncounterUi StoredVariable663 = ((EncounterUi)subContext662.GetComponent(typeof(EncounterUi))); //IsContext = False IsNew = False
					if(StoredVariable663 != null)
					{
						UnityEngine.GameObject prop664 = StoredVariable663.ShowedObject; //IsContext = False IsNew = False
						if(prop664 != null)
						{
							WinEvent StoredVariable665 = ((WinEvent)prop664.GetComponent(typeof(WinEvent))); //IsContext = False IsNew = False
							if(StoredVariable665 != null)
							{
								System.String prop666 = StoredVariable665.Why; //IsContext = False IsNew = False
								if(prop666 != null)
								{
									OperandVar667 = prop666;
								}
							}
						}
					}
					subContext662.Description = (System.String)( (OperandVar667));
				}
			}
		}
        }
    }
}
