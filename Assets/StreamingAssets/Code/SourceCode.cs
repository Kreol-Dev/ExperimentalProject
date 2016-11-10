namespace generators {
    
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
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
					People AddContext19 = (People)city.AddComponent(typeof(People)); //IsContext = True IsNew = True
					Named AddContext20 = (Named)city.AddComponent(typeof(Named)); //IsContext = True IsNew = True
					
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
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(city, 0.1f);
			}
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class temp_cultist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar26 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable25 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable25 != null)
			{
				applicable = true;
				OperandVar26 = applicable;
			}
			return (System.Boolean) (OperandVar26);
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class temp_enc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar28 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable27 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable27 != null)
			{
				applicable = true;
				OperandVar28 = applicable;
			}
			return (System.Boolean) (OperandVar28);
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class temp_nobles : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
			Story StoredVariable29 = ((Story)root.GetComponent(typeof(Story))); //IsContext = False IsNew = False
			if(StoredVariable29 != null)
			{
				applicable = true;
				OperandVar30 = applicable;
			}
			return (System.Boolean) (OperandVar30);
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
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=false, OncePerTurn=false)]
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable31 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				Markers StoredVariable32 = ((Markers)StoredVariable31.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					System.Boolean ifResult33; //IsContext = False IsNew = False
					
					System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						UnityEngine.GameObject prop34 = StoredVariable31.ShowedObject; //IsContext = False IsNew = False
						if(prop34 != null)
						{
							System.Boolean ifResult35; //IsContext = False IsNew = False
							System.Boolean OperandVar39 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar37 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable36 = ((Named)prop34.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable36 != null)
							{
								OperandVar37 = StoredVariable36;
							}
							System.Boolean prop38 = External.Has( (OperandVar37)); //IsContext = False IsNew = False
							OperandVar39 = prop38;
							if(ifResult35 =  (OperandVar39))
							{
								OperandVar40 = ifResult35;
							}
						}
					}
					
					System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
					OperandVar41 = "named_ui_marker";
					System.Boolean prop42 = StoredVariable32.HasMarker( (OperandVar41)); //IsContext = False IsNew = False
					OperandVar43 = prop42;
					if(ifResult33 = ( ( (OperandVar40))) && ( (!(OperandVar43))))
					{
						applicable = true;
						OperandVar44 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar44);
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
			
			UnityEngine.GameObject OperandVar45 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar45 = root;
			UnityEngine.GameObject ctx =  (OperandVar45); //IsContext = False IsNew = False
			
			{
				BarsManager subContext46 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext46 ContextSwitchInterpreter
				if(subContext46 != null)
				{
					UnityEngine.GameObject OperandVar48 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop47 = subContext46.GetLeftBar(); //IsContext = False IsNew = False
					if(prop47 != null)
					{
						OperandVar48 = prop47;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar48); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext49 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext49 ContextPropertySwitchInterpreter
						if(subContext49 != null)
						{
							System.Boolean OperandVar53 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar51 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable50 = ((UiObject)subContext49.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable50 != null)
							{
								OperandVar51 = StoredVariable50;
							}
							System.Boolean prop52 = External.Has( (OperandVar51)); //IsContext = False IsNew = False
							OperandVar53 = prop52;
							if( (OperandVar53))
							{
								UnityEngine.GameObject OperandVar54 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar54 = p_ctx;
								ctx =  (OperandVar54);
							}
						}
					}
				}
			}
			
			{
				Markers subContext55 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext55 ContextSwitchInterpreter
				if(subContext55 != null)
				{
					System.String OperandVar56 = default(System.String); //IsContext = False IsNew = False
					OperandVar56 = "named_ui_marker";
					subContext55.SetUiMarker(( (OperandVar56)).ToString());
				}
			}
			
			{
				UnityEngine.GameObject subContext57 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext57 ContextPropertySwitchInterpreter
				if(subContext57 != null)
				{
					
					{
						UiObject subContext58 = (UiObject)subContext57.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
						//ContextStatement UiObject subContext58 ContextSwitchInterpreter
						if(subContext58 != null)
						{
							Named OperandVar61 = default(Named); //IsContext = False IsNew = False
							UnityEngine.GameObject prop59 = subContext58.ShowedObject; //IsContext = False IsNew = False
							if(prop59 != null)
							{
								Named StoredVariable60 = ((Named)prop59.GetComponent(typeof(Named))); //IsContext = False IsNew = False
								if(StoredVariable60 != null)
								{
									OperandVar61 = StoredVariable60;
								}
							}
							Named showed_named =  (OperandVar61); //IsContext = False IsNew = False
							TextField ContextVar62 = subContext57.AddComponent<TextField>();; //IsContext = False IsNew = True
							
							{
								//ContextStatement TextField ContextVar62 ContextSwitchInterpreter
								if(ContextVar62 != null)
								{
									System.String OperandVar64 = default(System.String); //IsContext = False IsNew = False
									System.String prop63 = showed_named.FullName; //IsContext = False IsNew = False
									if(prop63 != null)
									{
										OperandVar64 = prop63;
									}
									ContextVar62.Show(( (OperandVar64)).ToString());
									
									{
										//ContextStatement Named showed_named ContextSwitchInterpreter
										if(showed_named != null)
										{
											VoidDelegate Lambda65 = () => 
											{
												System.String OperandVar67 = default(System.String); //IsContext = False IsNew = False
												System.String prop66 = showed_named.FullName; //IsContext = False IsNew = False
												if(prop66 != null)
												{
													OperandVar67 = prop66;
												}
												ContextVar62.Show(( (OperandVar67)).ToString());
											};
											showed_named.OnUpdate(Lambda65);
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext68 = ContextVar62.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext68 ContextPropertySwitchInterpreter
										if(subContext68 != null)
										{
											
											subContext68.minHeight = (System.Single)( (20f));
										}
									}
									
									{
										UnityEngine.UI.LayoutElement subContext69 = ContextVar62.Layout; //IsContext = True IsNew = False
										//ContextStatement UnityEngine.UI.LayoutElement subContext69 ContextPropertySwitchInterpreter
										if(subContext69 != null)
										{
											
											subContext69.minWidth = (System.Single)( (100f));
										}
									}
								}
							}
							Entity EntVar70 = (Entity)subContext57.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
							if(EntVar70 != null) EntVar70.ComponentAdded();
						}
					}
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
			
			System.Boolean OperandVar79 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable71 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable71 != null)
			{
				Place StoredVariable72 = ((Place)StoredVariable71.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable72 != null)
				{
					System.Boolean ifResult73; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar75 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop74 = StoredVariable72.Agents; //IsContext = False IsNew = False
					if(prop74 != null)
					{
						OperandVar75 = prop74;
					}
					
					
					
					System.Boolean OperandVar78 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar76 = default(System.String); //IsContext = False IsNew = False
					OperandVar76 = "agents_pool";
					System.Boolean prop77 = StoredVariable71.HasMarker( (OperandVar76)); //IsContext = False IsNew = False
					OperandVar78 = prop77;
					if(ifResult73 = ( (( ( (OperandVar75 != null ? OperandVar75.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar78))))
					{
						applicable = true;
						OperandVar79 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar79);
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
				Place subContext80 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext80 ContextSwitchInterpreter
				if(subContext80 != null)
				{
					
					subContext80.Size = (System.Int32)( (5f));
					System.Single OperandVar82 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop81 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar82 = prop81;
					for (int i = 0; i <  (OperandVar82); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag83 = ag; //IsContext = True IsNew = False
							Entity AddContext84 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext85 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext86 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext86 ContextSwitchInterpreter
								if(AddContext86 != null)
								{
									System.Single OperandVar88 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop87 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar88 = prop87;
									AddContext86.Age = (System.Int32)( (OperandVar88));
								}
							}
							Named AddContext89 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext89 ContextSwitchInterpreter
								if(AddContext89 != null)
								{
									
									
									
									AddContext89.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar92 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar90 = default(System.String); //IsContext = False IsNew = False
									OperandVar90 = "human_name";
									System.String prop91 = External.RandomName( (OperandVar90)); //IsContext = False IsNew = False
									if(prop91 != null)
									{
										OperandVar92 = prop91;
									}
									AddContext89.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar92)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag, 0.1f);
						Agent OperandVar94 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable93 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable93 != null)
						{
							OperandVar94 = StoredVariable93;
						}
						subContext80.Attach((Agent)( (OperandVar94)));
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
			
			System.Boolean OperandVar101 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable95 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable95 != null)
			{
				System.Boolean ifResult96; //IsContext = False IsNew = False
				System.Boolean OperandVar100 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar98 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable97 = ((Blackboards.event_marker)StoredVariable95.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable97 != null)
				{
					OperandVar98 = StoredVariable97;
				}
				System.Boolean prop99 = External.Has( (OperandVar98)); //IsContext = False IsNew = False
				OperandVar100 = prop99;
				if(ifResult96 = !(OperandVar100))
				{
					applicable = true;
					OperandVar101 = applicable;
				}
			}
			return (System.Boolean) (OperandVar101);
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
			Entity EntVar102 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar102 != null) EntVar102.ComponentAdded();
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
			
			System.Boolean OperandVar109 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable103 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable103 != null)
			{
				System.Boolean ifResult104; //IsContext = False IsNew = False
				System.Boolean OperandVar108 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar106 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable105 = ((Blackboards.personality)StoredVariable103.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable105 != null)
				{
					OperandVar106 = StoredVariable105;
				}
				System.Boolean prop107 = External.Has( (OperandVar106)); //IsContext = False IsNew = False
				OperandVar108 = prop107;
				if(ifResult104 = !(OperandVar108))
				{
					applicable = true;
					OperandVar109 = applicable;
				}
			}
			return (System.Boolean) (OperandVar109);
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
			Entity EntVar110 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar110 != null) EntVar110.ComponentAdded();
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
			
			System.Boolean OperandVar117 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable111 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable111 != null)
			{
				System.Boolean ifResult112; //IsContext = False IsNew = False
				System.Boolean OperandVar116 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar114 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable113 = ((Blackboards.aged_generation)StoredVariable111.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable113 != null)
				{
					OperandVar114 = StoredVariable113;
				}
				System.Boolean prop115 = External.Has( (OperandVar114)); //IsContext = False IsNew = False
				OperandVar116 = prop115;
				if(ifResult112 = !(OperandVar116))
				{
					applicable = true;
					OperandVar117 = applicable;
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
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar118 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar118 != null) EntVar118.ComponentAdded();
		}
        }
    }
    
    [EventActionAttribute(ShouldHaveMaxUtility=false, Category="basic", OncePerObject=true, OncePerTurn=false)]
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar120 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable119 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable119 != null)
			{
				applicable = true;
				OperandVar120 = applicable;
			}
			return (System.Boolean) (OperandVar120);
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
			
			UnityEngine.GameObject OperandVar121 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar121 = root;
			External.MapEnlistDetailed((UnityEngine.GameObject)( (OperandVar121)));
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
			
			System.Boolean OperandVar128 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable122 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable122 != null)
			{
				Markers StoredVariable123 = ((Markers)StoredVariable122.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable123 != null)
				{
					System.Boolean ifResult124; //IsContext = False IsNew = False
					System.Boolean OperandVar127 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar125 = default(System.String); //IsContext = False IsNew = False
					OperandVar125 = "encounter_ui_enlist";
					System.Boolean prop126 = StoredVariable123.HasMarker( (OperandVar125)); //IsContext = False IsNew = False
					OperandVar127 = prop126;
					if(ifResult124 = !(OperandVar127))
					{
						applicable = true;
						OperandVar128 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar128);
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
				Markers subContext129 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext129 ContextSwitchInterpreter
				if(subContext129 != null)
				{
					System.String OperandVar130 = default(System.String); //IsContext = False IsNew = False
					OperandVar130 = "encounter_ui_enlist";
					subContext129.SetUiMarker(( (OperandVar130)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar131 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar131 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar131)));
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
			
			System.Boolean OperandVar137 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable132 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable132 != null)
			{
				Named StoredVariable133 = ((Named)StoredVariable132.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable133 != null)
				{
					System.Boolean ifResult134; //IsContext = False IsNew = False
					
					System.Boolean OperandVar136 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable132 != null)
					{
						System.Boolean prop135 = StoredVariable132.Act; //IsContext = False IsNew = False
						OperandVar136 = prop135;
					}
					
					
					if(ifResult134 = ( ( (OperandVar136))) == ( ( (true))))
					{
						applicable = true;
						OperandVar137 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar137);
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
				UnityEngine.GameObject enc138 = enc; //IsContext = True IsNew = False
				Encounter AddContext139 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext139 ContextSwitchInterpreter
					if(AddContext139 != null)
					{
						UnityEngine.GameObject OperandVar140 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar140 = root;
						AddContext139.Context = (UnityEngine.GameObject)( (OperandVar140));
					}
				}
				Markers AddContext141 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext142 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext143 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext143 ContextSwitchInterpreter
					if(AddContext143 != null)
					{
						System.String OperandVar144 = default(System.String); //IsContext = False IsNew = False
						OperandVar144 = "main_name";
						
						
						AddContext143.Set(( (OperandVar144)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
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
			
			System.Boolean OperandVar158 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable145 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable145 != null)
			{
				Markers StoredVariable146 = ((Markers)StoredVariable145.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable146 != null)
				{
					System.Boolean ifResult147; //IsContext = False IsNew = False
					
					System.Boolean OperandVar154 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable145 != null)
					{
						UnityEngine.GameObject prop148 = StoredVariable145.ShowedObject; //IsContext = False IsNew = False
						if(prop148 != null)
						{
							System.Boolean ifResult149; //IsContext = False IsNew = False
							System.Boolean OperandVar153 = default(System.Boolean); //IsContext = False IsNew = False
							Place OperandVar151 = default(Place); //IsContext = False IsNew = False
							Place StoredVariable150 = ((Place)prop148.GetComponent(typeof(Place))); //IsContext = False IsNew = False
							if(StoredVariable150 != null)
							{
								OperandVar151 = StoredVariable150;
							}
							System.Boolean prop152 = External.Has( (OperandVar151)); //IsContext = False IsNew = False
							OperandVar153 = prop152;
							if(ifResult149 =  (OperandVar153))
							{
								OperandVar154 = ifResult149;
							}
						}
					}
					
					System.Boolean OperandVar157 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar155 = default(System.String); //IsContext = False IsNew = False
					OperandVar155 = "place_ui_cards_list";
					System.Boolean prop156 = StoredVariable146.HasMarker( (OperandVar155)); //IsContext = False IsNew = False
					OperandVar157 = prop156;
					if(ifResult147 = ( ( (OperandVar154))) && ( (!(OperandVar157))))
					{
						applicable = true;
						OperandVar158 = applicable;
					}
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
			
			UnityEngine.GameObject OperandVar159 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar159 = root;
			UnityEngine.GameObject ctx =  (OperandVar159); //IsContext = False IsNew = False
			
			{
				BarsManager subContext160 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext160 ContextSwitchInterpreter
				if(subContext160 != null)
				{
					UnityEngine.GameObject OperandVar162 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop161 = subContext160.GetBottomBar(); //IsContext = False IsNew = False
					if(prop161 != null)
					{
						OperandVar162 = prop161;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar162); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext163 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext163 ContextPropertySwitchInterpreter
						if(subContext163 != null)
						{
							System.Boolean OperandVar167 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar165 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable164 = ((UiObject)subContext163.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable164 != null)
							{
								OperandVar165 = StoredVariable164;
							}
							System.Boolean prop166 = External.Has( (OperandVar165)); //IsContext = False IsNew = False
							OperandVar167 = prop166;
							if( (OperandVar167))
							{
								UnityEngine.GameObject OperandVar168 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar168 = p_ctx;
								ctx =  (OperandVar168);
							}
						}
					}
				}
			}
			
			{
				Markers subContext169 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext169 ContextSwitchInterpreter
				if(subContext169 != null)
				{
					System.String OperandVar170 = default(System.String); //IsContext = False IsNew = False
					OperandVar170 = "place_ui_cards_list";
					subContext169.SetUiMarker(( (OperandVar170)).ToString());
				}
			}
			Place OperandVar174 = default(Place); //IsContext = False IsNew = False
			UiObject StoredVariable171 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable171 != null)
			{
				UnityEngine.GameObject prop172 = StoredVariable171.ShowedObject; //IsContext = False IsNew = False
				if(prop172 != null)
				{
					Place StoredVariable173 = ((Place)prop172.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable173 != null)
					{
						OperandVar174 = StoredVariable173;
					}
				}
			}
			Place pl =  (OperandVar174); //IsContext = False IsNew = False
			System.String OperandVar175 = default(System.String); //IsContext = False IsNew = False
			OperandVar175 = "place_cards";
			
			{
				UnityEngine.GameObject FuncCtx176 = External.SpawnPrefab(( (OperandVar175)).ToString());; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject FuncCtx176 ContextPropertySwitchInterpreter
				if(FuncCtx176 != null)
				{
					
					{
						AgentsUI subContext177 = (AgentsUI)FuncCtx176.GetComponent(typeof(AgentsUI)); //IsContext = True IsNew = False
						//ContextStatement AgentsUI subContext177 ContextSwitchInterpreter
						if(subContext177 != null)
						{
							Place OperandVar178 = default(Place); //IsContext = False IsNew = False
							OperandVar178 = pl;
							subContext177.TargetPlace = (Place)( (OperandVar178));
						}
					}
					
					{
						CardsHolderAgentsAdapter subContext179 = (CardsHolderAgentsAdapter)FuncCtx176.GetComponent(typeof(CardsHolderAgentsAdapter)); //IsContext = True IsNew = False
						//ContextStatement CardsHolderAgentsAdapter subContext179 ContextSwitchInterpreter
						if(subContext179 != null)
						{
							Place OperandVar180 = default(Place); //IsContext = False IsNew = False
							OperandVar180 = pl;
							subContext179.TargetPlace = (Place)( (OperandVar180));
						}
					}
					UnityEngine.GameObject OperandVar181 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar181 = FuncCtx176;
					UnityEngine.GameObject OperandVar182 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar182 = ctx;
					External.SetParent((UnityEngine.GameObject)( (OperandVar181)),(UnityEngine.GameObject)( (OperandVar182)));
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
			
			System.Boolean OperandVar188 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable183 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable183 != null)
			{
				System.Boolean ifResult184; //IsContext = False IsNew = False
				System.Boolean OperandVar187 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop185 = StoredVariable183.ShowedObject; //IsContext = False IsNew = False
				if(prop185 != null)
				{
					Place StoredVariable186 = ((Place)prop185.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable186 != null)
					{
						applicable = true;
						OperandVar187 = applicable;
					}
				}
				if(ifResult184 =  (OperandVar187))
				{
					applicable = true;
					OperandVar188 = applicable;
				}
			}
			return (System.Boolean) (OperandVar188);
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
			
			UnityEngine.GameObject OperandVar189 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar189 = root;
			UnityEngine.GameObject ctx =  (OperandVar189); //IsContext = False IsNew = False
			
			{
				BarsManager subContext190 = (BarsManager)root.GetComponent(typeof(BarsManager)); //IsContext = True IsNew = False
				//ContextStatement BarsManager subContext190 ContextSwitchInterpreter
				if(subContext190 != null)
				{
					UnityEngine.GameObject OperandVar192 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					UnityEngine.GameObject prop191 = subContext190.GetLeftBar(); //IsContext = False IsNew = False
					if(prop191 != null)
					{
						OperandVar192 = prop191;
					}
					UnityEngine.GameObject p_ctx =  (OperandVar192); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject subContext193 = p_ctx; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext193 ContextPropertySwitchInterpreter
						if(subContext193 != null)
						{
							System.Boolean OperandVar197 = default(System.Boolean); //IsContext = False IsNew = False
							UiObject OperandVar195 = default(UiObject); //IsContext = False IsNew = False
							UiObject StoredVariable194 = ((UiObject)subContext193.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable194 != null)
							{
								OperandVar195 = StoredVariable194;
							}
							System.Boolean prop196 = External.Has( (OperandVar195)); //IsContext = False IsNew = False
							OperandVar197 = prop196;
							if( (OperandVar197))
							{
								UnityEngine.GameObject OperandVar198 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar198 = p_ctx;
								ctx =  (OperandVar198);
							}
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext199 = ctx; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext199 ContextPropertySwitchInterpreter
				if(subContext199 != null)
				{
					TextField ContextVar200 = subContext199.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar200 ContextSwitchInterpreter
						if(ContextVar200 != null)
						{
							
							ContextVar200.Label = (System.String)( ("size"));
							System.Int32 OperandVar205 = default(System.Int32); //IsContext = False IsNew = False
							UiObject StoredVariable201 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
							if(StoredVariable201 != null)
							{
								UnityEngine.GameObject prop202 = StoredVariable201.ShowedObject; //IsContext = False IsNew = False
								if(prop202 != null)
								{
									Place StoredVariable203 = ((Place)prop202.GetComponent(typeof(Place))); //IsContext = False IsNew = False
									if(StoredVariable203 != null)
									{
										System.Int32 prop204 = StoredVariable203.Size; //IsContext = False IsNew = False
										OperandVar205 = prop204;
									}
								}
							}
							ContextVar200.Show(( (OperandVar205)).ToString());
							
							{
								UnityEngine.UI.LayoutElement subContext206 = ContextVar200.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext206 ContextPropertySwitchInterpreter
								if(subContext206 != null)
								{
									
									subContext206.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext207 = ContextVar200.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext207 ContextPropertySwitchInterpreter
								if(subContext207 != null)
								{
									
									subContext207.minWidth = (System.Single)( (100f));
								}
							}
						}
					}
					Entity EntVar208 = (Entity)subContext199.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar208 != null) EntVar208.ComponentAdded();
				}
			}
		}
        }
    }
}
