namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="")]
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
			
			System.Single OperandVar9 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop8 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
			OperandVar9 = prop8;
			for (int i = 0; i <  (OperandVar9); i++)
			{
				UnityEngine.GameObject city = new UnityEngine.GameObject("city"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject city10 = city; //IsContext = True IsNew = False
					Entity AddContext11 = (Entity)city.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Entity AddContext11 ContextSwitchInterpreter
						if(AddContext11 != null)
						{
							UnityEngine.Vector3 OperandVar17 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
							System.Single OperandVar13 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop12 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar13 = prop12;
							System.Single OperandVar15 = default(System.Single); //IsContext = False IsNew = False
							
							
							System.Single prop14 = External.Random( (10f), (90f)); //IsContext = False IsNew = False
							OperandVar15 = prop14;
							UnityEngine.Vector3 prop16 = External.Vec( (OperandVar13), (OperandVar15)); //IsContext = False IsNew = False
							OperandVar17 = prop16;
							AddContext11.Position = (UnityEngine.Vector3)( (OperandVar17));
						}
					}
					Place AddContext18 = (Place)city.AddComponent(typeof(Place)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Place AddContext18 ContextSwitchInterpreter
						if(AddContext18 != null)
						{
							
							AddContext18.Size = (System.Int32)( (100f));
						}
					}
					Named AddContext19 = (Named)city.AddComponent(typeof(Named)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Named AddContext19 ContextSwitchInterpreter
						if(AddContext19 != null)
						{
							System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
							OperandVar20 = "main_name";
							
							System.String OperandVar23 = default(System.String); //IsContext = False IsNew = False
							System.String OperandVar21 = default(System.String); //IsContext = False IsNew = False
							OperandVar21 = "country_name";
							System.String prop22 = External.RandomName( (OperandVar21)); //IsContext = False IsNew = False
							if(prop22 != null)
							{
								OperandVar23 = prop22;
							}
							AddContext19.Set(( (OperandVar20)).ToString(),(System.Single)( (0f)),( (OperandVar23)).ToString());
						}
					}
					Interactables AddContext24 = (Interactables)city.AddComponent(typeof(Interactables)); //IsContext = True IsNew = True
					Interactable AddContext25 = (Interactable)city.AddComponent(typeof(Interactable)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(city, 0.1f);
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class temp_cultist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar27 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable26 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable26 != null)
			{
				applicable = true;
				OperandVar27 = applicable;
			}
			return (System.Boolean) (OperandVar27);
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class temp_enc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar29 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable28 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable28 != null)
			{
				applicable = true;
				OperandVar29 = applicable;
			}
			return (System.Boolean) (OperandVar29);
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class temp_nobles : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable30 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable30 != null)
			{
				applicable = true;
				OperandVar31 = applicable;
			}
			return (System.Boolean) (OperandVar31);
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar45 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable32 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable32 != null)
			{
				Markers StoredVariable33 = ((Markers)StoredVariable32.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable33 != null)
				{
					System.Boolean ifResult34; //IsContext = False IsNew = False
					
					System.Boolean OperandVar41 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable32 != null)
					{
						UnityEngine.GameObject prop35 = StoredVariable32.ShowedObject; //IsContext = False IsNew = False
						if(prop35 != null)
						{
							System.Boolean ifResult36; //IsContext = False IsNew = False
							System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar38 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable37 = ((Named)prop35.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable37 != null)
							{
								OperandVar38 = StoredVariable37;
							}
							System.Boolean prop39 = External.Has( (OperandVar38)); //IsContext = False IsNew = False
							OperandVar40 = prop39;
							if(ifResult36 =  (OperandVar40))
							{
								OperandVar41 = ifResult36;
							}
						}
					}
					
					System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar42 = default(System.String); //IsContext = False IsNew = False
					OperandVar42 = "named_ui_marker";
					System.Boolean prop43 = StoredVariable33.HasMarker( (OperandVar42)); //IsContext = False IsNew = False
					OperandVar44 = prop43;
					if(ifResult34 = ( ( (OperandVar41))) && ( (!(OperandVar44))))
					{
						applicable = true;
						OperandVar45 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar45);
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
			
			UnityEngine.GameObject OperandVar46 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar46 = root;
			UnityEngine.GameObject ctx =  (OperandVar46); //IsContext = False IsNew = False
			
			{
				BarsManager subContext47 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext47 ContextSwitchInterpreter
				if(subContext47 != null)
				{
					UnityEngine.GameObject OperandVar49 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop48 = subContext47.GetLeftBar(); //IsContext = False IsNew = False
					if(prop48 != null)
					{
						OperandVar49 = prop48;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar49); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext50 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext50 ContextPropertySwitchInterpreter
						if(subContext50 != null)
						{
							System.Boolean OperandVar54 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar52 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable51 = ((UiObject)subContext50.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable51 != null)
							{
								OperandVar52 = StoredVariable51;
							}
							System.Boolean prop53 = External.Has( (OperandVar52)); //IsContext = False IsNew = False
							OperandVar54 = prop53;
							if( (OperandVar54))
							{
								UnityEngine.GameObject OperandVar55 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar55 = p_ctx;
								ctx =  (OperandVar55);
							}
						}
					}
				}
			}
			
			{
				Markers subContext56 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext56 ContextSwitchInterpreter
				if(subContext56 != null)
				{
					System.String OperandVar57 = default(System.String); //IsContext = False IsNew = False
					OperandVar57 = "named_ui_marker";
					subContext56.SetUiMarker(( (OperandVar57)).ToString());
				}
			}
			
			{
				UnityEngine.GameObject subContext58 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext58 ContextPropertySwitchInterpreter
				if(subContext58 != null)
				{
					
					{
						UiObject subContext59 = (UiObject)subContext58.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
						//ContextStatement UiObject subContext59 ContextSwitchInterpreter
						if(subContext59 != null)
						{
							Named OperandVar62 = default(Named); //IsContext = False IsNew = False
							UnityEngine.GameObject prop60 = subContext59.ShowedObject; //IsContext = False IsNew = False
							if(prop60 != null)
							{
								Named StoredVariable61 = ((Named)prop60.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable61 != null)
								{
									OperandVar62 = StoredVariable61;
								}
							}
							Named showed_named =  (OperandVar62); //IsContext = False IsNew = False
							TextField ContextVar63 = subContext58.AddComponent<TextField>();; //IsContext = False IsNew = True
							
							{
								//ContextStatement TextField ContextVar63 ContextSwitchInterpreter
								if(ContextVar63 != null)
								{
									System.String OperandVar65 = default(System.String); //IsContext = False IsNew = False
									System.String prop64 = showed_named.FullName; //IsContext = False IsNew = False
									if(prop64 != null)
									{
										OperandVar65 = prop64;
									}
									ContextVar63.Show(( (OperandVar65)).ToString());
									
									{
										//ContextStatement Named showed_named ContextSwitchInterpreter
										if(showed_named != null)
										{
											VoidDelegate Lambda66 = () => 
											{
												System.String OperandVar68 = default(System.String); //IsContext = False IsNew = False
												System.String prop67 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop67 != null)
												{
													OperandVar68 = prop67;
												}
												ContextVar63.Show(( (OperandVar68)).ToString());
											};
											showed_named.OnUpdate(Lambda66);
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext69 = ContextVar63.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext69 ContextPropertySwitchInterpreter
										if(subContext69 != null)
										{
											
											subContext69.minHeight = (System.Single)( (20f));
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext70 = ContextVar63.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext70 ContextPropertySwitchInterpreter
										if(subContext70 != null)
										{
											
											subContext70.minWidth = (System.Single)( (100f));
										}
									}
								}
							}
							Entity EntVar71 = (Entity)subContext58.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
							if(EntVar71 != null) EntVar71.ComponentAdded();
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar80 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable72 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable72 != null)
			{
				Place StoredVariable73 = ((Place)StoredVariable72.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable73 != null)
				{
					System.Boolean ifResult74; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar76 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop75 = StoredVariable73.Agents; //IsContext = False IsNew = False
					if(prop75 != null)
					{
						OperandVar76 = prop75;
					}
					
					
					
					System.Boolean OperandVar79 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar77 = default(System.String); //IsContext = False IsNew = False
					OperandVar77 = "agents_pool";
					System.Boolean prop78 = StoredVariable72.HasMarker( (OperandVar77)); //IsContext = False IsNew = False
					OperandVar79 = prop78;
					if(ifResult74 = ( (( ( (OperandVar76 != null ? OperandVar76.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar79))))
					{
						applicable = true;
						OperandVar80 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar80);
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
				Place subContext81 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext81 ContextSwitchInterpreter
				if(subContext81 != null)
				{
					
					subContext81.Size = (System.Int32)( (5f));
					System.Single OperandVar83 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop82 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar83 = prop82;
					for (int i = 0; i <  (OperandVar83); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag84 = ag; //IsContext = True IsNew = False
							Entity AddContext85 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext86 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext87 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext87 ContextSwitchInterpreter
								if(AddContext87 != null)
								{
									System.Single OperandVar89 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop88 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar89 = prop88;
									AddContext87.Age = (System.Int32)( (OperandVar89));
								}
							}
							Named AddContext90 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext90 ContextSwitchInterpreter
								if(AddContext90 != null)
								{
									
									
									
									AddContext90.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar93 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar91 = default(System.String); //IsContext = False IsNew = False
									OperandVar91 = "human_name";
									System.String prop92 = External.RandomName( (OperandVar91)); //IsContext = False IsNew = False
									if(prop92 != null)
									{
										OperandVar93 = prop92;
									}
									AddContext90.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar93)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar95 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable94 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable94 != null)
						{
							OperandVar95 = StoredVariable94;
						}
						subContext81.Attach((Agent)( (OperandVar95)));
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar102 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable96 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable96 != null)
			{
				System.Boolean ifResult97; //IsContext = False IsNew = False
				System.Boolean OperandVar101 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar99 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable98 = ((Blackboards.event_marker)StoredVariable96.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable98 != null)
				{
					OperandVar99 = StoredVariable98;
				}
				System.Boolean prop100 = External.Has( (OperandVar99)); //IsContext = False IsNew = False
				OperandVar101 = prop100;
				if(ifResult97 = !(OperandVar101))
				{
					applicable = true;
					OperandVar102 = applicable;
				}
			}
			return (System.Boolean) (OperandVar102);
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
			Entity EntVar103 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar103 != null) EntVar103.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar110 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable104 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable104 != null)
			{
				System.Boolean ifResult105; //IsContext = False IsNew = False
				System.Boolean OperandVar109 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar107 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable106 = ((Blackboards.personality)StoredVariable104.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable106 != null)
				{
					OperandVar107 = StoredVariable106;
				}
				System.Boolean prop108 = External.Has( (OperandVar107)); //IsContext = False IsNew = False
				OperandVar109 = prop108;
				if(ifResult105 = !(OperandVar109))
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
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar111 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar111 != null) EntVar111.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar118 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable112 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable112 != null)
			{
				System.Boolean ifResult113; //IsContext = False IsNew = False
				System.Boolean OperandVar117 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar115 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable114 = ((Blackboards.aged_generation)StoredVariable112.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable114 != null)
				{
					OperandVar115 = StoredVariable114;
				}
				System.Boolean prop116 = External.Has( (OperandVar115)); //IsContext = False IsNew = False
				OperandVar117 = prop116;
				if(ifResult113 = !(OperandVar117))
				{
					applicable = true;
					OperandVar118 = applicable;
				}
			}
			return (System.Boolean) (OperandVar118);
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
			Entity EntVar119 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar119 != null) EntVar119.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar121 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable120 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable120 != null)
			{
				applicable = true;
				OperandVar121 = applicable;
			}
			return (System.Boolean) (OperandVar121);
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
			
			UnityEngine.GameObject OperandVar122 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar122 = root;
			External.MapEnlistDetailed((UnityEngine.GameObject)( (OperandVar122)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar129 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable123 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable123 != null)
			{
				Markers StoredVariable124 = ((Markers)StoredVariable123.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable124 != null)
				{
					System.Boolean ifResult125; //IsContext = False IsNew = False
					System.Boolean OperandVar128 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar126 = default(System.String); //IsContext = False IsNew = False
					OperandVar126 = "encounter_ui_enlist";
					System.Boolean prop127 = StoredVariable124.HasMarker( (OperandVar126)); //IsContext = False IsNew = False
					OperandVar128 = prop127;
					if(ifResult125 = !(OperandVar128))
					{
						applicable = true;
						OperandVar129 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar129);
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
				Markers subContext130 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext130 ContextSwitchInterpreter
				if(subContext130 != null)
				{
					System.String OperandVar131 = default(System.String); //IsContext = False IsNew = False
					OperandVar131 = "encounter_ui_enlist";
					subContext130.SetUiMarker(( (OperandVar131)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar132 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar132 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar132)));
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar138 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable133 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable133 != null)
			{
				Named StoredVariable134 = ((Named)StoredVariable133.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable134 != null)
				{
					System.Boolean ifResult135; //IsContext = False IsNew = False
					
					System.Boolean OperandVar137 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable133 != null)
					{
						System.Boolean prop136 = StoredVariable133.Act; //IsContext = False IsNew = False
						OperandVar137 = prop136;
					}
					
					
					if(ifResult135 = ( ( (OperandVar137))) == ( ( (true))))
					{
						applicable = true;
						OperandVar138 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar138);
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
				UnityEngine.GameObject enc139 = enc; //IsContext = True IsNew = False
				Encounter AddContext140 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext140 ContextSwitchInterpreter
					if(AddContext140 != null)
					{
						UnityEngine.GameObject OperandVar141 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar141 = root;
						AddContext140.Context = (UnityEngine.GameObject)( (OperandVar141));
					}
				}
				Markers AddContext142 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext143 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext144 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext144 ContextSwitchInterpreter
					if(AddContext144 != null)
					{
						System.String OperandVar145 = default(System.String); //IsContext = False IsNew = False
						OperandVar145 = "main_name";
						
						
						AddContext144.Set(( (OperandVar145)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc, 0.1f);
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class place_ui_cards_list : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar159 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable146 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable146 != null)
			{
				Markers StoredVariable147 = ((Markers)StoredVariable146.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable147 != null)
				{
					System.Boolean ifResult148; //IsContext = False IsNew = False
					
					System.Boolean OperandVar155 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable146 != null)
					{
						UnityEngine.GameObject prop149 = StoredVariable146.ShowedObject; //IsContext = False IsNew = False
						if(prop149 != null)
						{
							System.Boolean ifResult150; //IsContext = False IsNew = False
							System.Boolean OperandVar154 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar152 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable151 = ((Place)prop149.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable151 != null)
							{
								OperandVar152 = StoredVariable151;
							}
							System.Boolean prop153 = External.Has( (OperandVar152)); //IsContext = False IsNew = False
							OperandVar154 = prop153;
							if(ifResult150 =  (OperandVar154))
							{
								OperandVar155 = ifResult150;
							}
						}
					}
					
					System.Boolean OperandVar158 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar156 = default(System.String); //IsContext = False IsNew = False
					OperandVar156 = "place_ui_cards_list";
					System.Boolean prop157 = StoredVariable147.HasMarker( (OperandVar156)); //IsContext = False IsNew = False
					OperandVar158 = prop157;
					if(ifResult148 = ( ( (OperandVar155))) && ( (!(OperandVar158))))
					{
						applicable = true;
						OperandVar159 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar159);
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
			
			UnityEngine.GameObject OperandVar160 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar160 = root;
			UnityEngine.GameObject ctx =  (OperandVar160); //IsContext = False IsNew = False
			
			{
				BarsManager subContext161 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext161 ContextSwitchInterpreter
				if(subContext161 != null)
				{
					UnityEngine.GameObject OperandVar163 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop162 = subContext161.GetBottomBar(); //IsContext = False IsNew = False
					if(prop162 != null)
					{
						OperandVar163 = prop162;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar163); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext164 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext164 ContextPropertySwitchInterpreter
						if(subContext164 != null)
						{
							System.Boolean OperandVar168 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar166 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable165 = ((UiObject)subContext164.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable165 != null)
							{
								OperandVar166 = StoredVariable165;
							}
							System.Boolean prop167 = External.Has( (OperandVar166)); //IsContext = False IsNew = False
							OperandVar168 = prop167;
							if( (OperandVar168))
							{
								UnityEngine.GameObject OperandVar169 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar169 = p_ctx;
								ctx =  (OperandVar169);
							}
						}
					}
				}
			}
			
			{
				Markers subContext170 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext170 ContextSwitchInterpreter
				if(subContext170 != null)
				{
					System.String OperandVar171 = default(System.String); //IsContext = False IsNew = False
					OperandVar171 = "place_ui_cards_list";
					subContext170.SetUiMarker(( (OperandVar171)).ToString());
				}
			}
			Place OperandVar175 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable172 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable172 != null)
			{
				UnityEngine.GameObject prop173 = StoredVariable172.ShowedObject; //IsContext = False IsNew = False
				if(prop173 != null)
				{
					Place StoredVariable174 = ((Place)prop173.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable174 != null)
					{
						OperandVar175 = StoredVariable174;
					}
				}
			}
			Place pl =  (OperandVar175); //IsContext = False IsNew = False
			System.String OperandVar176 = default(System.String); //IsContext = False IsNew = False
			OperandVar176 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx177 = External.SpawnPrefab(( (OperandVar176)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx177 ContextPropertySwitchInterpreter
				if(FuncCtx177 != null)
				{
					
					{
						AgentsUI subContext178 = (AgentsUI)FuncCtx177.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext178 ContextSwitchInterpreter
						if(subContext178 != null)
						{
							Place OperandVar179 = default(Place); //IsContext = False IsNew = False
							OperandVar179 = pl;
							subContext178.TargetPlace = (Place)( (OperandVar179));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext180 = (CardsHolderAgentsAdapter)FuncCtx177.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext180 ContextSwitchInterpreter
						if(subContext180 != null)
						{
							Place OperandVar181 = default(Place); //IsContext = False IsNew = False
							OperandVar181 = pl;
							subContext180.TargetPlace = (Place)( (OperandVar181));
						}
					}
					UnityEngine.GameObject OperandVar182 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar182 = FuncCtx177;
					UnityEngine.GameObject OperandVar183 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar183 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar182)),(UnityEngine.GameObject)( (OperandVar183)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="ui", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class place_ui_size : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar189 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable184 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable184 != null)
			{
				System.Boolean ifResult185; //IsContext = False IsNew = False
				System.Boolean OperandVar188 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop186 = StoredVariable184.ShowedObject; //IsContext = False IsNew = False
				if(prop186 != null)
				{
					Place StoredVariable187 = ((Place)prop186.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable187 != null)
					{
						applicable = true;
						OperandVar188 = applicable;
					}
				}
				if(ifResult185 =  (OperandVar188))
				{
					applicable = true;
					OperandVar189 = applicable;
				}
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
			
			UnityEngine.GameObject OperandVar190 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar190 = root;
			UnityEngine.GameObject ctx =  (OperandVar190); //IsContext = False IsNew = False
			
			{
				BarsManager subContext191 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext191 ContextSwitchInterpreter
				if(subContext191 != null)
				{
					UnityEngine.GameObject OperandVar193 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop192 = subContext191.GetLeftBar(); //IsContext = False IsNew = False
					if(prop192 != null)
					{
						OperandVar193 = prop192;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar193); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext194 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext194 ContextPropertySwitchInterpreter
						if(subContext194 != null)
						{
							System.Boolean OperandVar198 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar196 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable195 = ((UiObject)subContext194.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable195 != null)
							{
								OperandVar196 = StoredVariable195;
							}
							System.Boolean prop197 = External.Has( (OperandVar196)); //IsContext = False IsNew = False
							OperandVar198 = prop197;
							if( (OperandVar198))
							{
								UnityEngine.GameObject OperandVar199 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar199 = p_ctx;
								ctx =  (OperandVar199);
							}
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext200 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext200 ContextPropertySwitchInterpreter
				if(subContext200 != null)
				{
					TextField ContextVar201 = subContext200.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar201 ContextSwitchInterpreter
						if(ContextVar201 != null)
						{
							
							ContextVar201.Label = (System.String)( ("size"));
							System.Int32 OperandVar206 = default(System.Int32); //IsContext = False IsNew = False
							UiObject StoredVariable202 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable202 != null)
							{
								UnityEngine.GameObject prop203 = StoredVariable202.ShowedObject; //IsContext = False IsNew = False
								if(prop203 != null)
								{
									Place StoredVariable204 = ((Place)prop203.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable204 != null)
									{
										System.Int32 prop205 = StoredVariable204.Size; //IsContext = False IsNew = False
										OperandVar206 = prop205;
									}
								}
							}
							ContextVar201.Show(( (OperandVar206)).ToString());
							
							{
								UnityEngine.UI.LayoutElement subContext207 = ContextVar201.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext207 ContextPropertySwitchInterpreter
								if(subContext207 != null)
								{
									
									subContext207.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext208 = ContextVar201.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext208 ContextPropertySwitchInterpreter
								if(subContext208 != null)
								{
									
									subContext208.minWidth = (System.Single)( (100f));
								}
							}
						}
					}
					Entity EntVar209 = (Entity)subContext200.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar209 != null) EntVar209.ComponentAdded();
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class interactables_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar219 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable210 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable210 != null)
			{
				System.Boolean ifResult211; //IsContext = False IsNew = False
				System.Boolean OperandVar218 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop212 = StoredVariable210.ShowedObject; //IsContext = False IsNew = False
				if(prop212 != null)
				{
					System.Boolean ifResult213; //IsContext = False IsNew = False
					System.Boolean OperandVar217 = default(System.Boolean); //IsContext = False IsNew = False
					Interactables OperandVar215 = default(Interactables); //IsContext = False IsNew = False
					Interactables StoredVariable214 = ((Interactables)prop212.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable214 != null)
					{
						OperandVar215 = StoredVariable214;
					}
					System.Boolean prop216 = External.Has( (OperandVar215)); //IsContext = False IsNew = False
					OperandVar217 = prop216;
					if(ifResult213 =  (OperandVar217))
					{
						OperandVar218 = ifResult213;
					}
				}
				if(ifResult211 =  (OperandVar218))
				{
					applicable = true;
					OperandVar219 = applicable;
				}
			}
			return (System.Boolean) (OperandVar219);
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
			
			UnityEngine.GameObject OperandVar220 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar220 = root;
			UnityEngine.GameObject ctx =  (OperandVar220); //IsContext = False IsNew = False
			
			{
				BarsManager subContext221 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext221 ContextSwitchInterpreter
				if(subContext221 != null)
				{
					UnityEngine.GameObject OperandVar223 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop222 = subContext221.GetTopBar(); //IsContext = False IsNew = False
					if(prop222 != null)
					{
						OperandVar223 = prop222;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar223); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext224 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext224 ContextPropertySwitchInterpreter
						if(subContext224 != null)
						{
							System.Boolean OperandVar228 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar226 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable225 = ((UiObject)subContext224.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable225 != null)
							{
								OperandVar226 = StoredVariable225;
							}
							System.Boolean prop227 = External.Has( (OperandVar226)); //IsContext = False IsNew = False
							OperandVar228 = prop227;
							if( (OperandVar228))
							{
								UnityEngine.GameObject OperandVar229 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar229 = p_ctx;
								ctx =  (OperandVar229);
							}
						}
					}
				}
			}
			Interactables OperandVar233 = default(Interactables); //IsContext = False IsNew = False
			UiObject StoredVariable230 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable230 != null)
			{
				UnityEngine.GameObject prop231 = StoredVariable230.ShowedObject; //IsContext = False IsNew = False
				if(prop231 != null)
				{
					Interactables StoredVariable232 = ((Interactables)prop231.GetComponent(typeof(Interactables))); //IsContext = False IsNew = False
					if(StoredVariable232 != null)
					{
						OperandVar233 = StoredVariable232;
					}
				}
			}
			Interactables inter =  (OperandVar233); //IsContext = False IsNew = False
			System.String OperandVar234 = default(System.String); //IsContext = False IsNew = False
			OperandVar234 = "interactables_ui";
			
			{
				UnityEngine.GameObject FuncCtx235 = External.SpawnPrefab(( (OperandVar234)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx235 ContextPropertySwitchInterpreter
				if(FuncCtx235 != null)
				{
					
					{
						InteractablesUI subContext236 = (InteractablesUI)FuncCtx235.GetComponent(typeof(InteractablesUI)); //IsContext = True IsNew = False
						//ContextStatement InteractablesUI subContext236 ContextSwitchInterpreter
						if(subContext236 != null)
						{
							Interactables OperandVar237 = default(Interactables); //IsContext = False IsNew = False
							OperandVar237 = inter;
							subContext236.TargetInteractables = (Interactables)( (OperandVar237));
						}
					}
					UnityEngine.GameObject OperandVar238 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar238 = FuncCtx235;
					UnityEngine.GameObject OperandVar239 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar239 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar238)),(UnityEngine.GameObject)( (OperandVar239)));
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false, IsInteraction=false, Tooltip="")]
    public class interactable_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar249 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable240 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable240 != null)
			{
				System.Boolean ifResult241; //IsContext = False IsNew = False
				System.Boolean OperandVar248 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop242 = StoredVariable240.ShowedObject; //IsContext = False IsNew = False
				if(prop242 != null)
				{
					System.Boolean ifResult243; //IsContext = False IsNew = False
					System.Boolean OperandVar247 = default(System.Boolean); //IsContext = False IsNew = False
					Interactable OperandVar245 = default(Interactable); //IsContext = False IsNew = False
					Interactable StoredVariable244 = ((Interactable)prop242.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
					if(StoredVariable244 != null)
					{
						OperandVar245 = StoredVariable244;
					}
					System.Boolean prop246 = External.Has( (OperandVar245)); //IsContext = False IsNew = False
					OperandVar247 = prop246;
					if(ifResult243 =  (OperandVar247))
					{
						OperandVar248 = ifResult243;
					}
				}
				if(ifResult241 =  (OperandVar248))
				{
					applicable = true;
					OperandVar249 = applicable;
				}
			}
			return (System.Boolean) (OperandVar249);
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
			
			UnityEngine.GameObject OperandVar250 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar250 = root;
			UnityEngine.GameObject ctx =  (OperandVar250); //IsContext = False IsNew = False
			
			{
				BarsManager subContext251 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext251 ContextSwitchInterpreter
				if(subContext251 != null)
				{
					UnityEngine.GameObject OperandVar253 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop252 = subContext251.GetRightBar(); //IsContext = False IsNew = False
					if(prop252 != null)
					{
						OperandVar253 = prop252;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar253); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext254 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext254 ContextPropertySwitchInterpreter
						if(subContext254 != null)
						{
							System.Boolean OperandVar258 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar256 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable255 = ((UiObject)subContext254.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable255 != null)
							{
								OperandVar256 = StoredVariable255;
							}
							System.Boolean prop257 = External.Has( (OperandVar256)); //IsContext = False IsNew = False
							OperandVar258 = prop257;
							if( (OperandVar258))
							{
								UnityEngine.GameObject OperandVar259 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar259 = p_ctx;
								ctx =  (OperandVar259);
							}
						}
					}
				}
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false, IsInteraction=true, Tooltip="")]
    public class interaction_log_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar262 = default(System.Boolean); //IsContext = False IsNew = False
			Interactable StoredVariable260 = ((Interactable)root.GetComponent(typeof(Interactable))); //IsContext = False IsNew = False
			if(StoredVariable260 != null)
			{
				Named StoredVariable261 = ((Named)StoredVariable260.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable261 != null)
				{
					applicable = true;
					OperandVar262 = applicable;
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
			
			System.String OperandVar265 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable263 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable263 != null)
			{
				System.String prop264 = StoredVariable263.FullName; //IsContext = False IsNew = False
				if(prop264 != null)
				{
					OperandVar265 = prop264;
				}
			}
			External.Log((System.Object)( (OperandVar265)));
		}
        }
    }
}
